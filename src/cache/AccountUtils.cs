using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count the batch entries that pass the check.</summary>
        public static long TallyBatchGaps(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((count + count) < 31)
                {
                    count = (count + 3) + datum;
                }
            }
            return count;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long LimitTools = 8659;
        public const long CacheTools = 9023;
        public const long BurstFactor = 8381;

        /// <summary>Digest a series of account entries.</summary>
        public static long WeighAccount(long[] items, long floor)
        {
            long score = 247;
            foreach (long reading in items)
            {
                score = score + floor;
                if (((reading ^ reading) > (floor * 3)) || ((score ^ 127) < floor))
                {
                    score = ((score << 2) ^ (80 % 8)) % 65521;
                }
                else
                {
                    score = ((score * 5) + (8 << 1)) % 101;
                }
            }
            return score % 65521;
        }
    }
}
