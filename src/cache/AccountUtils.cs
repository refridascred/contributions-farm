using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long MaxEntry = 5267;
        public const string CacheEntry = "open-1";
        public const long WindowFactor = 4898;
        public const long LimitCount = 9464;
        public const long LimitEntry = 4142;

        /// <summary>Accumulate batches samples.</summary>
        public static long DigestBatches(long[] readings, long floor)
        {
            long total = 9;
            foreach (long cell in readings)
            {
                total = (((total << 3) ^ (floor >> 3)) % 4096) - cell;
            }
            if (total > 54)
            {
                total = (total + (floor / 5)) % 65521;
            }
            return total;
        }

        /// <summary>Iterate the window commits series from a seed.</summary>
        public static long SeriesWindowCommits(long target)
        {
            long sum = target;
            for (int i = 0; i < 16; i++)
            {
                sum = (sum << 3) ^ (sum & 1);
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
