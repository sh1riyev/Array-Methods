//HOMEWORK - Method yazirsiz, Method stringden ibaret array ve char qebul edir.
//Method arrayin icerisinde gelen chardan ne qederdirse onlarin sayini geriye qaytarsin.


int CountChar(string[]arr,char a)
{
    int count = 0;
    arr = Array.ConvertAll(arr, x => x.ToLower());
    a = char.ToLower(a);
    foreach (var item in arr)
    {
        char[] items = item.ToCharArray();
        foreach (var letter in items)
        {
            if (letter == a)
            {
                count++;
            }
        }
    }
    return count;
}

//string[] names = { "Anar", "Ilqar", "Baku" };
//char check = 'A';
//int result = CountChar(names, check);
//Console.WriteLine(result);

////////////////////////////////////////////

string[] names = { "Hacixan", "Reshad", "Kamran", "Ilqar" };

//string[] arr1 = new string[4];
//string[] arr2 = new string[2] { "ilqar", "Baki"};

//Console.WriteLine(names[names.Length-1]);
//Console.WriteLine(names[2]);

//for (int i = 0; i < names.Length; i++)
//{
//    Console.WriteLine(i);
//}

//foreach (var name in names)
//{
//    Console.WriteLine(name);
//}

int[,,] nums = { { { 1, 2 }, { 2, 3 }, { 4, 5 } }, { { 2, 3 }, { 4, 5 }, { 6, 7 } }  };

//Console.WriteLine(nums.Rank);

//Console.WriteLine(nums[0,3]);
//Console.WriteLine(nums[0,1,1]);

//Console.WriteLine(names.Contains("Ilqar"));

//var datas = names.Reverse().ToArray();
//Console.WriteLine(datas[datas.Length-1]);

//Array.Sort(names);
//foreach (var item in names)
//{
//    Console.WriteLine(item);


//int[] nums1 = { 6, 2, 3, 4 };
//Array.Sort(nums1);
//var datas = nums1.Reverse().ToArray();
//foreach (var item in datas)
//{
//    Console.WriteLine(item);
//}

//int[] nums1 = { 1, 2 };
//int[] nums2 = { 3, 4, 5 };
//nums1.CopyTo(nums2, 1);

//int[] arr = { 1, 2, 3 };
//Array.Resize(ref arr, 5);
//arr[3] = 150;
//Console.WriteLine(arr[4]);

//int[] arr1 = { 1, 2, 3 };
//int[] arr2 = { 4, 5 };

//Array.Resize(ref arr2, 5);
//arr1.CopyTo(arr2, 2);
//foreach (var item in arr2)
//{
//    Console.WriteLine(item );
//}

//var data = Array.Find(names, m => m == "Ilqar");
//Console.WriteLine(data);

//var data = Array.FindIndex(names, m => m == "Ilqar");
//Console.WriteLine(data);

//var data = Array.FindLast(names, m => m == "Ilqar");
//Console.WriteLine(data);

//var data = names.FirstOrDefault();
//Console.WriteLine(data);

//var data = names.LastOrDefault();
//Console.WriteLine(data);

//var data = names.All(m => m=="Ilqar");
//Console.WriteLine(data);

//var data = names.Any(m => m == "Ilqar");
//Console.WriteLine(data);

//var data = Array.Exists(names, m => m == "ilqar");
//Console.WriteLine(data);

//var datas = names.Where(m => m == "Ilqar").ToArray();
//foreach (var item in datas)
//{
//    Console.WriteLine(item);
//}

//var datas = names.OrderByDescending(m => m);
//foreach (var item in datas)
//{
//    Console.WriteLine(item);
//}

bool CheckString(string[]arr,string name)
{
    bool isTrue = true;
    foreach (var item in arr)
    {
        if (item != name)
        {
            isTrue = false;
            break;
        }
        isTrue = true;
    }
    return isTrue;
}

//string[] datas = { "China", "China", "Ilqar" };
//string name = "China";
//Console.WriteLine(CheckString(datas,name));

//DateTime date = DateTime.Now.AddYears(10);
//Console.WriteLine(date);

//DateTime birthday = new DateTime(1998, 02, 18);
//Console.WriteLine(birthday.Day);

//DateOnly date = new DateOnly(1998,02,18);
//Console.WriteLine(date);

//var date = DateTime.Now;
//Console.WriteLine(date.ToString("MM/dddd/yyyyy HH:mm"));

//var currentYear = DateTime.Now.Year;
//DateTime birthDay = new DateTime(1998, 02, 18);
//var birthdayYear = birthDay.Year;
//Console.WriteLine(currentYear-birthdayYear);