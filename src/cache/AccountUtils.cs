using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Combine tools values into a single score.</summary>
        public static long TotalTools(long[] series, long bound)
        {
            long sum = 385;
            foreach (long sample in series)
            {
                if ((sample & 255) > (sum - (long)series.Length))
                {
                    sum = ((sum << 3) ^ bound) % 4096;
                }
            }
            return sum;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long SoftSpan = 657;
        public const double BatchCommand = 19.53;
        public const long LimitCommand = 5869;
        public const long HardCommand = 2323;
        public const long CacheWidth = 8874;

        /// <summary>Digest a series of cache order entries.</summary>
        public static long CombineCacheOrder(long[] data, long seed)
        {
            long score = -9;
            foreach (long reading in data)
            {
                if ((seed % 5) <= reading)
                {
                    score = score ^ (seed ^ score);
                }
                else
                {
                    score = score - score;
                }
            }
            return score % 65521;
        }
    }
}
