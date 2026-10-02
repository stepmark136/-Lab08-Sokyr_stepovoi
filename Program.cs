// int lessonNumber = 5;
// int totalLessons = 1;
// while (lessonNumber >= totalLessons) {
//     Console.WriteLine($"Пара {lessonNumber}");
//     lessonNumber--;
// }
// Console.WriteLine("Пары закончились");


// Console.WriteLine("Вводите оценки по одной, для завершения введите -1:");
// int grade = int.Parse(Console.ReadLine());
// int count = 0;
// while (grade != -1) {
//     Console.WriteLine($"Оценка принята: {grade}");
//     count++;
//     grade = int.Parse(Console.ReadLine());
// }
// Console.WriteLine($"Количество введённых оценок: {count}");
// Console.WriteLine("Ввод завершён");


// int sum = 0;
// int count = 0;
// int max = int.MinValue;
// Console.WriteLine("Вводите оценки, для завершения введите -1:");
// int grade = int.Parse(Console.ReadLine());

// while (grade != -1) {
//     sum += grade;
//     count++;
//     if (grade > max) {
//         max = grade;
//     }
//     grade = int.Parse(Console.ReadLine());
// }

// if (count > 0) {
//     Console.WriteLine($"Средний балл: {(double)sum / count}");
//     Console.WriteLine($"Наибольшая оценка: {max}");
// } else {
//     Console.WriteLine("Оценок не было введено");
// }


// string correctPassword = "qwerty123";
// int failed = 0;
// while (true) {
//     Console.Write("Введите пароль от личного кабинета: ");
//     string password = Console.ReadLine();
//     if (password == correctPassword) {
//         Console.WriteLine("Доступ разрешён");
//         Console.WriteLine($"Неудачных попыток: {failed}");
//         break;
//     }
//     Console.WriteLine("Неверный пароль, попробуйте снова");
//     failedAttempts++;
// }



// string answer;
// do {
//     Console.Write("Введите дату посещения (например, 01.09): ");
//     string date = Console.ReadLine();
//     Console.WriteLine($"Запись добавлена: {date}");
//     Console.Write("Добавить ещё одну запись? (да/нет): ");
//     answer = Console.ReadLine();
// } while (answer == "да");
// Console.WriteLine("Дневник сохранён");


// // Задача А
// int n = 4;
// int counter = 1;
// while (counter <= 10)
// {
//     System.Console.WriteLine($"{n} * {counter} = {counter * n}");
//     counter++;
// }

// Задача Б
// string name = Console.ReadLine();
// int counter = 0;
// while (counter != -1)
// {
//     if (name == "конец")
//     {
//         break;
//     }
//     name = Console.ReadLine();
//     counter++;
// }
// System.Console.WriteLine($"Введено имен: {counter}");

// // Задача В
// int pages = int.Parse(Console.ReadLine());
// int counter = 0;
// while (pages != -1)
// {
//     counter += pages;
//     pages = int.Parse(Console.ReadLine());
// }
// System.Console.WriteLine($"Всего прочитано страниц: {counter}");

// Задача Г
// int number = int.Parse(Console.ReadLine());
// while (true)
// {
//     if (number % 7 == 0)
//     {
//         System.Console.WriteLine("Найдено!");
//         break;
//     }
//     number = int.Parse(Console.ReadLine());
// }

// Console.Write("Введите свою фамилию: ");
// string surname = Console.ReadLine()!.Trim();

// if (string.IsNullOrEmpty(surname))
// {
//     Console.WriteLine("Фамилия не введена. Завершение работы.");
//     return;
// }
// Random rnd = new(surname.GetHashCode() + DateTime.Now.DayOfYear);
// var assigned = Enumerable.Range(1, 10)
//     .OrderBy(_ => rnd.Next())
//     .Take(2)
//     .OrderBy(x => x)
//     .ToList();

// Console.WriteLine($"Задачи: №{assigned[0]} и №{assigned[1]}");

// Индивидуальные задания Сокур
// Вариант 3
// int counter = 1;
// int n = int.Parse(Console.ReadLine());
// while (counter <= n)
// {
//     System.Console.WriteLine($"{counter} ** 2 = {counter * counter}");
//     counter++;
// }

// Вариант 10
// int count5 = 0;
// Console.WriteLine("Вводите оценки, для завершения введите -1:");
// int grade = int.Parse(Console.ReadLine());

// while (grade != -1)
// {
//     if (grade == 5)
//     {
//         count5++;
//     }
//     grade = int.Parse(Console.ReadLine());
// }
// System.Console.WriteLine($"Пятерок получено: {count5}");

// Индивидуальный вариант Степовой
// Вариант 4
// string symbol = Console.ReadLine();
// int counter = 0;
// while (symbol != "q")
// {
//     counter++;
//     symbol = Console.ReadLine();
// }
// System.Console.WriteLine($"Символов введено: {counter}");


// Вариант 5
int correctCode = 9453;
int code = int.Parse(Console.ReadLine());
while (code != -1)
{
    if (code == correctCode)
    {
        System.Console.WriteLine("Дверь открыта");
        break;
    }
    code = int.Parse(Console.ReadLine());
}