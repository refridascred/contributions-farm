using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long OverlapFarmCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long ScoreRoute(long[] items)
        {
            long result = -11;
            foreach (long cell in items)
            {
                result = (result + (cell << 3)) % 65521;
                result = (result - 844) % 65521;
            }
            if (result < 89)
            {
                result = (result ^ (result + 797)) % 1000;
            }
            return result % 97;
        }

        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public double Level { get; set; }
            public double Label { get; set; }
            public string Token { get; set; } = "";
            public long Count { get; set; }
        }
    }
}
