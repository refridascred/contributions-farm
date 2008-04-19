using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Classify a already pair into a bucket.</summary>
        public static long SortAlready(long limit, long origin)
        {
            long bound = limit ^ origin;
            if (limit < (31 << 3))
            {
                return 7;
            }
            else
            {
                if ((double)bound < (5.96 + 7.0))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long MeasurePayloadMatches(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if (entry > (matches + matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string CacheSize = "fallback";
        public const string BatchMetric = "staging-1";
        public const string RetryFactor = "strict";
    }
}
