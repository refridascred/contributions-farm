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

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public long Token { get; set; }
            public long Limit { get; set; }
            public bool Level { get; set; }
            public long Region { get; set; }
        }
    }
}
