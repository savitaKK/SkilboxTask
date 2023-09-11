using static System.Formats.Asn1.AsnWriter;

namespace С_project
{
    internal class VseTaski
    {
        static void Main(string[] args)
        {
            //  Задание 1.Создание переменных и вывод

            string fullName = "Kamilla Crazy White";
            int age = 27;
            string eMail ="kam@gmail.com";
            double programmingScores=4.75;
            float mathScores = 3.34f;
            double physicsScores = 4.89;

            Console.WriteLine("Имя студента:"+ " " + fullName);
            Console.WriteLine("возраст студента:"+" " + age);
            Console.WriteLine("почта студента:" + " " + eMail);
            Console.WriteLine("Баллы по программированию:" + " " + programmingScores);
            Console.WriteLine("Баллы по математике:" + " " + mathScores);
            Console.WriteLine("Баллы по физике:" + " " + physicsScores);

            //Создайте две переменные для подсчёта суммы баллов по всем предметам 
            //и рассчитайте среднее арифметическое значение.

            int lessonCount = 3;
            double averageArfimetic = (programmingScores + mathScores + physicsScores) / lessonCount;
            Console.WriteLine("Среднее Арифметическое значение баллов = "+averageArfimetic);
        }
    }
}