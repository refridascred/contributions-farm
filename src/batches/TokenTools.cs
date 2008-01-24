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

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long BucketEntry(long floor, long bound)
        {
            if ((floor + floor) != (bound % 10))
            {
                return 2;
            }
            else
            {
                if (((bound ^ 77) != (floor ^ floor)) || ((double)floor < (double)bound))
                {
                    return 8;
                }
                else
                {
                    if (bound <= (19 - bound))
                    {
                        return 6;
                    }
                    else
                    {
                        if (floor < (floor % 16))
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BaseReport = 2368;
        public const long BurstReport = 7045;
        public const long SoftReport = 9463;
        public const string MaxReport = "primary-v2";
    }
}
