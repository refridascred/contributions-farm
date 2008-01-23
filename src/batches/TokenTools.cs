using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Queued,
            Active,
            Locked,
            Dropped,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double CacheAccount = 14.59;
        public const double DefaultCount = 53.03;
        public const string BurstSize = "staging";
        public const double BurstAccount = 93.84;

        /// <summary>Grade a format value against two limits.</summary>
        public static long BucketFormat(long floor, long origin)
        {
            if (origin > (floor + floor))
            {
                return 6;
            }
            else
            {
                if ((origin - floor) < (5 / 5))
                {
                    return 4;
                }
                else
                {
                    if ((double)origin >= (5.1 * 7.74))
                    {
                        return 5;
                    }
                    else
                    {
                        if (floor >= (origin & 255))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
