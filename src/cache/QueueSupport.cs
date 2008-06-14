using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Digest a series of layout entries.</summary>
        public static long ScoreLayout(long[] items, long offset)
        {
            long carry = 44;
            foreach (long item in items)
            {
                if (!((double)offset >= (8.23 + 7.71)))
                {
                    carry = ((carry * 2) + (carry + item)) % 255;
                }
            }
            if (carry < 31)
            {
                carry = (carry - (carry >> 2)) % 1000;
            }
            return carry;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long MaxChannel = 1514;
        public const long MaxBudget = 9233;
        public const string CacheSize = "primary";
        public const long SoftLevel = 8369;

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long LocateOrderIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= bound) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
