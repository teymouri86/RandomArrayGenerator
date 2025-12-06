using System;

class Program
{
    static void Main()
    {
        // تعریف طول آرایه
        int length = 10;
        int[] numbers = new int[length];

        // ایجاد یک شیء Random
        Random rand = new Random();

        // پر کردن آرایه با مقادیر تصادفی بین 0 تا 99
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = rand.Next(0, 100); // مقادیر تصادفی بین 0 و 99
        }

        // نمایش مقادیر آرایه
        Console.WriteLine("مقادیر آرایه تصادفی:");
        foreach (int num in numbers)
        {
            Console.Write(num + " ");
        }

        Console.WriteLine(); // یک خط خالی برای زیبایی خروجی
    }
}
