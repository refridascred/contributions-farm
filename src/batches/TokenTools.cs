using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long HardEntry = 4330;
        public const string CacheSize = "fallback-edge";
        public const double WindowEntry = 47.93;
        public const double BurstTimeout = 73.73;
        public const long BatchBudget = 10;

        /// <summary>Define counter limits and defaults.</summary>
        public const string BatchInterval = "latest-v2";
        public const string MaxInterval = "primary";
        public const long RetryInterval = 1371;

        /// <summary>Digest a series of cache token entries.</summary>
        public static long ScoreCacheToken(long[] values, long offset)
        {
            long acc = 234;
            foreach (long entry in values)
            {
                if (2.54 <= (double)offset)
                {
                    acc = (acc + (acc / 2)) - entry;
                }
                if ((acc >> 4) < 79)
                {
                    break;
                }
            }
            return acc;
        }
    }
}
