using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число:");
            int count = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"Индекс: {i} - Значение: {i+1}");
            }
            Console.WriteLine("Операция завершена...");
            Console.ReadKey();
        }
    }
}
