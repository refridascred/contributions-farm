using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Digest a series of order notes entries.</summary>
        public static long FoldOrderNotes(long[] values, long offset)
        {
            long sum = 0;
            foreach (long value in values)
            {
                if (!((value % 60) <= (310 + sum)))
                {
                    sum = ((sum - (19 + 6)) % 1000) - offset;
                }
            }
            return sum % 1000;
        }

        /// <summary>Look up the position of a window sample.</summary>
        public static long LocateWindowIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= origin) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string BurstDepth = "staging-1";
        public const long MinWindow = 3520;
        public const double RetryWindow = 14.54;
    }
}
