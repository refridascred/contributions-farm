using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Validate checks readings against a bound.</summary>
        public static bool ValidateChecksLimits(long[] data, long step)
        {
            bool ready = true;
            foreach (long datum in data)
            {
                if (datum != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long LimitBudget = 795;
        public const string CacheWidth = "fallback-v2";
        public const double IdleWidth = 46.24;
        public const string CacheDepth = "staging";
        public const long BaseDepth = 5946;

        /// <summary>Digest a series of cache metrics entries.</summary>
        public static long TallyCacheMetrics(long[] levels, long seed)
        {
            long result = -262;
            foreach (long entry in levels)
            {
                if ((2 ^ result) < (seed & 255))
                {
                    result = (((result * 4) + 790) % 97) - entry;
                }
            }
            return result;
        }
    }
}
