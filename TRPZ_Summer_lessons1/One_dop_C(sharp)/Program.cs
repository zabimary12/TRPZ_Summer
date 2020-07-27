using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace One_dop_C_sharp_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            

            int action;
            Console.WriteLine("Виберіть завдання для роботи");
            Console.WriteLine("1.Zavdannya odun");
            Console.WriteLine("2.Zavdannya dwa");
            Console.WriteLine("3.Zavdannya tru");
            Console.WriteLine("4.Zavdannya choturu");
            action = int.Parse(Console.ReadLine());
            switch (action)
            {
                case 1:


                    //Перше завдання//
                    float A, B, C, Square;
                    float resultSquare, resultS;

                    Console.WriteLine("Введіть число А");
                    A = int.Parse(Console.ReadLine());

                    Console.WriteLine("Введіть число B");
                    B = int.Parse(Console.ReadLine());

                    Console.WriteLine("Введіть число C");
                    C = int.Parse(Console.ReadLine());

                    if (C > A || C > B)
                    {
                        Console.WriteLine("В прямокутнику неможливо розмістити жодного квадрату");
                        Console.ReadKey();
                    }
                    else
                    {
                        resultSquare = ((A * B) / (C * C));
                        Square = (int)resultSquare;
                        resultS = (resultSquare - Square) * (C * C);
                        Console.WriteLine("В прямокутнику з площею " + A * B + " можна вмістити " + Square + " квадратів зі стороноюv" + C);
                        Console.WriteLine("В свою чергу площа незайнятої частини становить:" + resultS);
                        Console.ReadKey();
                    }
                    //Перше завдання//
                    break;

                case 2:
                    {
                        float P, S = 0;
                        int K = 0;

                        Console.WriteLine("Введіть відсоткову ставку");
                        P = int.Parse(Console.ReadLine());
                        if( P<0 || P>25)
                        {
                            for (float Money = 1000; Money < 1100; K++)
                            {
                                Money = Money + (Money * (P / 100));
                                S = Money;
                            };
                            Console.WriteLine("Кількість місяців " + K + "\n Сумма на рахунку: " + S);
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("Некоректна відсоткова ставка");
                            Console.ReadKey();

                        }
                    }
            
                    break;

                case 3:
                    {
                        int A2, B2, help;

                        Console.WriteLine("Введіть число А");
                        A2 = int.Parse(Console.ReadLine());

                        Console.WriteLine("Введіть число B");
                        B2 = int.Parse(Console.ReadLine());
                        if (A2 <= B2)
                        {
                            for (; A2<=B2; A2++)
                            {
                                help = A2;
                               for(;help>0; help--)
                                {
                                    Console.Write(A2+" ");
                                }
                                Console.WriteLine();
                            }
                        }
                        else
                        {
                            Console.WriteLine("Eror");
                        }
                        Console.ReadKey();
                    }
                    break;


                case 4:
                    {
                        float N, N2=0, rec;
                        Console.WriteLine("Введіть число N");
                        N = int.Parse(Console.ReadLine());
                        while (N > 0)
                        {
                            rec = N % 10;
                            N2 = N2 * 10 +rec;
                            N = (int)N / 10;
                        }
                        Console.WriteLine(N2);
                        Console.ReadKey();
                    }
                    break;






                default:
                    Console.WriteLine("Eror");
                    Console.ReadKey();
                    break;
        }
        }
    }
}
