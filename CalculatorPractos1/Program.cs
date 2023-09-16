using System;
int choice;
int x;
int y;
int z;
do
{
    Console.WriteLine("Выберите действие:");
    Console.WriteLine("1. Сложить 2 числа");
    Console.WriteLine("2. Вычесть второе из первого");
    Console.WriteLine("3. Перемножить два числа");
    Console.WriteLine("4. Разделить первое на второе");
    Console.WriteLine("5. Возвести в степень N первое число");
    Console.WriteLine("6. Найти квадратный корень из числа");
    Console.WriteLine("7. Найти 1 процент от числа");
    Console.WriteLine("8. Найти факториал из числа");
    Console.WriteLine("9. Выйти из программы");
    Console.WriteLine("10. Пасхалка");
    choice = Convert.ToInt32(Console.ReadLine());
    switch (choice)
    {
        case 1:
            Console.WriteLine("Введите первое число");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            y = Convert.ToInt32(Console.ReadLine());
            z = x + y;
            Console.WriteLine("Результат " + z);
            Console.WriteLine();
            break;
        case 2:
            Console.WriteLine("Введите первое число");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            y = Convert.ToInt32(Console.ReadLine());
            z = x - y;
            Console.WriteLine("Результат " + z);
            Console.WriteLine();
            break;
        case 3:
            Console.WriteLine("Введите первое число");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            y = Convert.ToInt32(Console.ReadLine());
            z = x * y;
            Console.WriteLine("Результат " + z);
            Console.WriteLine();
            break;
        case 4:
            Console.WriteLine("Введите первое число");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            y = Convert.ToInt32(Console.ReadLine());
            z = x / y;
            Console.WriteLine("Результат " + z);
            Console.WriteLine();
            break;
        case 5:
            Console.WriteLine("Введите число");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите степень");
            y = Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i <= y; i+=1)
            {
                x*=x;
            }
            z = x;
            Console.WriteLine("Результат " + z);
            Console.WriteLine();
            break;
        case 6:
            Console.WriteLine("Введите число");
            x = Convert.ToInt32(Console.ReadLine());
            z = (int) Math.Sqrt(x);
            Console.WriteLine("Результат " + z);
            Console.WriteLine();
            break;
        case 7:
            double res;
            Console.WriteLine("Введите число");
            x = Convert.ToInt32(Console.ReadLine());
            res = Convert.ToDouble(x);
            res = (res * 0.01);
            Console.WriteLine("Результат " + res);
            Console.WriteLine();
            break;
        case 8:
            Console.WriteLine("Введите число");
            x = Convert.ToInt32(Console.ReadLine());
            z = 1;
            for (int i = 1; i <= x; i += 1)
            {
                z = z * i;
            }
            Console.WriteLine("Результат " + z);
            Console.WriteLine();
            break;
        case 10:
            Console.WriteLine("Never gonna give you up");
            Console.WriteLine("Never gonna let you down");
            Console.WriteLine("Never gonna run around and desert you");
            Console.WriteLine("Never gonna make you cry");
            Console.WriteLine("Never gonna say goodbye");
            Console.WriteLine("Never gonna tell a lie and hurt you");
    }
}
while (choice != 9);
