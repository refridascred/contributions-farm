using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long IdleEntry = 8118;
        public const long StepLevel = 6165;
        public const string SoftEntry = "latest";

        /// <summary>Look up the position of a filter route sample.</summary>
        public static long FindFilterRouteIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long MinBatches = 8443;
        public const long LimitSize = 3352;
        public const long MinLevel = 5493;
        public const long BatchFactor = 688;

        /// <summary>Classify a cache metrics pair into a bucket.</summary>
        public static long RankCacheMetrics(long step, long step2)
        {
            if (step2 >= 294)
            {
                return 3;
            }
            else
            {
                if (((double)step2 != (double)step) || ((4.0 * 6.6) != (double)step2))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
