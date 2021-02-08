using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_4_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            #region УсловияЗадачи
            // * Задание 3.1
            // Заказчику требуется приложение позволяющщее умножать математическую матрицу на число
            // Справка https://ru.wikipedia.org/wiki/Матрица_(математика)
            // Справка https://ru.wikipedia.org/wiki/Матрица_(математика)#Умножение_матрицы_на_число
            // Добавить возможность ввода количество строк и столцов матрицы и число,
            // на которое будет производиться умножение.
            // Матрицы заполняются автоматически. 
            // Если по введённым пользователем данным действие произвести невозможно - сообщить об этом
            //
            // Пример
            //
            //      |  1  3  5  |   |  5  15  25  |
            //  5 х |  4  5  7  | = | 20  25  35  |
            //      |  5  3  1  |   | 25  15   5  |
            //
            //
            // ** Задание 3.2
            // Заказчику требуется приложение позволяющщее складывать и вычитать математические матрицы
            // Справка https://ru.wikipedia.org/wiki/Матрица_(математика)
            // Справка https://ru.wikipedia.org/wiki/Матрица_(математика)#Сложение_матриц
            // Добавить возможность ввода количество строк и столцов матрицы.
            // Матрицы заполняются автоматически
            // Если по введённым пользователем данным действие произвести невозможно - сообщить об этом
            //
            // Пример
            //  |  1  3  5  |   |  1  3  4  |   |  2   6   9  |
            //  |  4  5  7  | + |  2  5  6  | = |  6  10  13  |
            //  |  5  3  1  |   |  3  6  7  |   |  8   9   8  |
            //  
            //  
            //  |  1  3  5  |   |  1  3  4  |   |  0   0   1  |
            //  |  4  5  7  | - |  2  5  6  | = |  2   0   1  |
            //  |  5  3  1  |   |  3  6  7  |   |  2  -3  -6  |
            //
            // *** Задание 3.3
            // Заказчику требуется приложение позволяющщее перемножать математические матрицы
            // Справка https://ru.wikipedia.org/wiki/Матрица_(математика)
            // Справка https://ru.wikipedia.org/wiki/Матрица_(математика)#Умножение_матриц
            // Добавить возможность ввода количество строк и столцов матрицы.
            // Матрицы заполняются автоматически
            // Если по введённым пользователем данным действие произвести нельзя - сообщить об этом
            //  
            //  |  1  3  5  |   |  1  3  4  |   | 22  48  57  |
            //  |  4  5  7  | х |  2  5  6  | = | 35  79  95  |
            //  |  5  3  1  |   |  3  6  7  |   | 14  36  45  |
            //
            //  
            //                  | 4 |   
            //  |  1  2  3  | х | 5 | = | 32 |
            //                  | 6 |  
            //
            #endregion

            #region Матрицы

            Random r = new Random();

            int n1 = 0, k1 = 0; // для размерности матрицы 1
            int n2 = 0, k2 = 0; // для размерности матрицы 2

            Console.WriteLine("Введите размерность матрицы 1");
            Console.Write("Количество строк: ");
            n1 = int.Parse(Console.ReadLine());
            Console.Write("Количество колонок: ");
            k1 = int.Parse(Console.ReadLine());

            Console.WriteLine("\nВведите размерность матрицы 2");
            Console.Write("Количество строк: ");
            n2 = int.Parse(Console.ReadLine());
            Console.Write("Количество колонок: ");
            k2 = int.Parse(Console.ReadLine());

            // инициализируем матрицы

            int[,] matrix1 = new int[n1, k1], matrix2 = new int[n2, k2], matrixMult = new int[n1, k2];
            Console.WriteLine();
            Console.WriteLine("Матрица 1:");
            for (int i = 0; i < n1; i++)
            {
                for (int j = 0; j < k1; j++)
                {
                    matrix1[i, j] = r.Next(10);
                    Console.Write($"{matrix1[i, j]} ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("Матрица 2:");

            for (int i = 0; i < n2; i++)
            {
                for (int j = 0; j < k2; j++)
                {
                    matrix2[i, j] = r.Next(10);
                    Console.Write($"{matrix2[i, j]} ");
                }
                Console.WriteLine();
            }

            if (n1 != n2 || k1 != k2)
                Console.WriteLine("Матрицы указанных размеров не удастся сложить");

            if (n2 != k1)
                Console.WriteLine("Матрицы указанных размеров не удастся перемножить");

            // Задание 3.1
            int mult = 0;
            Console.Write("Умножить матрицы на число: ");
            mult = int.Parse(Console.ReadLine());
            Console.WriteLine("\nРезультат умножения матрицы 1 на число: ");
            for (int i = 0; i < n1; i++)
            {
                for (int j = 0; j < k1; j++)
                {
                    Console.Write("{0,3}", $"{matrix1[i, j] * mult} ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nРезультат умножения матрицы 2 на число: ");
            for (int i = 0; i < n2; i++)
            {
                for (int j = 0; j < k2; j++)
                {
                    Console.Write("{0,3}", $"{matrix2[i, j] * mult} ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            // Задание 3.2
            if (n1 == n2 && k1 == k2)
            {
                Console.WriteLine("Результат сложения матриц:");
                for (int i = 0; i < n1; i++)
                {
                    for (int j = 0; j < k1; j++)
                    {
                        Console.Write("{0,3}", $"{matrix1[i, j] + matrix2[i, j]} ");
                    }
                    Console.WriteLine();
                }

                Console.WriteLine("Результат вычитания матриц:");
                for (int i = 0; i < n1; i++)
                {
                    for (int j = 0; j < k1; j++)
                    {
                        Console.Write("{0,3}", $"{matrix1[i, j] + matrix2[i, j] * (-1)} ");
                    }
                    Console.WriteLine();
                }
            }

            Console.WriteLine();

            // Задание 3.3
            if (n2 == k1)
            {
                Console.WriteLine("Результат умножения матриц:");
                for (int i = 0; i < n1; i++)
                {
                    for (int j = 0; j < k2; j++)
                    {
                        matrixMult[i, j] = 0;
                        for (int l = 0; l < k1; l++)
                        {
                            matrixMult[i, j] += matrix1[i, l] * matrix2[l, j];
                        }
                        Console.Write("{0,5}", matrixMult[i, j]);
                    }
                    Console.WriteLine();
                }
            }

            #endregion
            Console.ReadKey();
        }
    }
}
