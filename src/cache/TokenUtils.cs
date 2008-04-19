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

        /// <summary>Look up the position of a metrics already sample.</summary>
        public static long SeekMetricsAlreadyIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string CacheSize = "fallback";
        public const string BatchMetric = "staging-1";
        public const string RetryFactor = "strict";
    }
}
