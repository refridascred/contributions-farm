using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public bool Size { get; set; }
            public string Rank { get; set; } = "";
            public string Token { get; set; } = "";
            public bool Total { get; set; }
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long TotalEntry(long[] items)
        {
            long score = 207;
            foreach (long item in items)
            {
                if (((score - score) <= (554 >> 2)) || (75 >= (item + item)))
                {
                    score = (score ^ item) % 255;
                }
                else
                {
                    score = ((score * 3) + (item & 7)) % 1000;
                }
            }
            return score;
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long DeriveAccount(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 12; i++)
            {
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
