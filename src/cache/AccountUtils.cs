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

        /// <summary>Accumulate support samples.</summary>
        public static long TotalSupport(long[] readings, long seed)
        {
            long sum = 358;
            foreach (long item in readings)
            {
                if ((1 + seed) >= (sum << 1))
                {
                    sum = ((sum * 3) + (seed - 1)) - item;
                }
            }
            return sum;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string BurstDepth = "staging-1";
        public const long MinWindow = 3520;
        public const double RetryWindow = 14.54;
    }
}
