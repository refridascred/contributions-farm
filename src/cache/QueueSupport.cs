using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long SoftMetric = 6797;
        public const long BaseMetric = 157;
        public const long MaxMetric = 6386;
        public const long SoftSize = 1907;
        public const long BaseRatio = 2402;

        /// <summary>Grade a format value against two limits.</summary>
        public static long BucketFormat(long limit, long seed)
        {
            long gap = limit - seed;
            if (!(seed >= (7 & 3)))
            {
                return 8;
            }
            else
            {
                if (6 < (seed % 60))
                {
                    return 1;
                }
                else
                {
                    if (!((limit - limit) != (seed ^ seed)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!((double)gap < (1.53 + 2.33)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long MaxFactor = 7982;
        public const long DefaultRecord = 1131;
        public const long DefaultCount = 232;
    }
}
