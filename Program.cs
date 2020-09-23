using System;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            int a = 0;
            double b = 0;
            long c = 0;

            bool flag1 = true;
            bool flag2 = true;
            bool flag3 = true;
            while (flag1 == true)
            {
                try
                {
                    flag1 = false;
                    Console.WriteLine("Введіть змінну типу int:");
                    a = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    flag1 = true;
                    Console.WriteLine("Введіть коректний тип даних!");
                    continue;
                }

            }

            while (flag2 == true)
            {
                try
                {
                    flag2 = false;
                    Console.WriteLine("Введіть змінну типу double:");
                    b = Convert.ToDouble(Console.ReadLine());
                }
                catch
                {
                    flag2 = true;
                    Console.WriteLine("Введіть коректний тип даних!");
                    continue;
                }
            }


            while (flag3 == true)
            {
                try
                {
                    flag3 = false;
                    Console.WriteLine("Введіть змінну типу long:");
                    c = Convert.ToInt64(Console.ReadLine());
                }
                catch
                {
                    flag3 = true;
                    Console.WriteLine("Введіть коректний тип даних!");
                    continue;
                }
            }

            Console.WriteLine($"a = {a}; b = {b}; c = {c}.");
        }

            
        }
    }

