using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Grade a filter value against two limits.</summary>
        public static long BucketFilter(long floor, long seed)
        {
            long lane = floor ^ seed;
            if ((29 + floor) <= (lane >> 3))
            {
                return 2;
            }
            else
            {
                if ((10.0 + 6.0) < (double)lane)
                {
                    return 6;
                }
                else
                {
                    if ((4 - lane) <= (lane + floor))
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Idle,
            Stale,
            Active,
            Pending,
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long MeasureCacheOutliers(long[] values, long origin)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if (((3.07 - 1.93) <= (double)sample) || ((70 >> 1) < (origin >> 1)))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
