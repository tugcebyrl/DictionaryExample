namespace DictionaryExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, dictionary!");

            MyDictionaryExample<int,string> dict = new MyDictionaryExample<int, string>();
            dict.Add(25, "Player1");
            dict.Add(28, "Player2");
            dict.Add(32, "Player3");

            Console.WriteLine(dict.Count);

        }
    }

    class MyDictionaryExample<TKey, TValue>
    {
        TKey[] keys;
        TValue[] values;

        TKey[] tempKeys;
        TValue[] tempValues;



        public MyDictionaryExample()
        {
            keys = new TKey[0];
            values = new TValue[0];
        }

        public void Add(TKey item1, TValue item2)
        {
            tempKeys = keys;
            tempValues = values;

            keys = new TKey[tempKeys.Length + 1];
            values = new TValue[tempValues.Length + 1];

            for (int i = 0; i < tempKeys.Length; i++)
            {
                keys[i] = tempKeys[i];
                values[i] = tempValues[i];

            }
            keys[keys.Length - 1] = item1;
        }

        public int Count
        {
            //get { return keys.Length; }
            get { return values.Length; }
        }
    }
}