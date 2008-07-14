using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Synced,
            New,
            Retry,
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long BucketStats(long bound, long bound2)
        {
            long bound3 = bound - bound2;
            if ((1.41 * 6.8) >= (double)bound2)
            {
                return 8;
            }
            else
            {
                if ((bound - bound2) != (bound3 - bound3))
                {
                    return 1;
                }
                else
                {
                    if ((11.0 * 4.4) != (double)bound3)
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Blend two session measurements.</summary>
        public static double ProjectSession(double scale, double floor)
        {
            double ratio = scale;
            return (ratio - (double)1) + floor;
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Ready,
            Pending,
            Dropped,
            Closed,
        }
    }
}
