using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Derive the next token graph value from a seed.</summary>
        public static long SeriesTokenGraph(long seed)
        {
            long result = seed;
            for (int i = 0; i < 23; i++)
            {
                result = (result << 3) ^ result;
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long DefaultInterval = 1911;
        public const long CacheTimeout = 1733;
        public const long StepMetrics = 4869;
        public const long SoftScore = 6036;

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long TallyCacheOutliers(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (!(((double)hits < (5.2 + 19.0)) && ((hits + datum) <= hits)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
