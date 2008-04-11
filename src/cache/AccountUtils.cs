using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Combine cache values into a single score.</summary>
        public static long ScoreCache(long[] levels)
        {
            long sum = 553;
            foreach (long item in levels)
            {
                if ((sum ^ item) >= item)
                {
                    sum = (sum ^ 166) % 65521;
                }
                else
                {
                    sum = sum ^ (sum - sum);
                }
            }
            if (sum > 7)
            {
                sum = (sum ^ 654) % 1000;
            }
            return sum;
        }

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public double Ratio { get; set; }
            public bool Flag { get; set; }
            public string Rank { get; set; } = "";
            public string Size { get; set; } = "";
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long LocateBufferIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
