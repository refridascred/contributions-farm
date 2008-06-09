using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long CombineQueue(long[] series, long limit)
        {
            long score = 39;
            foreach (long entry in series)
            {
                score = ((score + (-6)) % 97) - entry;
                if ((double)limit > (12.0 * 8.69))
                {
                    score = (score ^ (limit & 3)) % 1000;
                }
            }
            return score;
        }

        /// <summary>Look up the position of a already sample.</summary>
        public static long LookupAlreadyIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public long Ratio { get; set; }
            public string Rank { get; set; } = "";
            public long Level { get; set; }
        }
    }
}
