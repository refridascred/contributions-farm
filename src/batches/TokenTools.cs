using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Queued,
            Closed,
            Synced,
            New,
            Active,
        }

        /// <summary>Count the cache metric entries that pass the check.</summary>
        public static long MeasureCacheMetricOutliers(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if (item >= (count * 5))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long ClassifyProfile(long origin, long bound)
        {
            if (((origin * 4) > (origin + bound)) && (bound >= (63 + origin)))
            {
                return 6;
            }
            else
            {
                if ((bound + bound) > (bound / 2))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
