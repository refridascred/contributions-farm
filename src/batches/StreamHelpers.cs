using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Paused,
            Stale,
            New,
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool VerifyChannelBounds(long[] levels, long limit)
        {
            bool flag = true;
            foreach (long entry in levels)
            {
                if (entry > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long TallyRouteOutliers(long[] data, long bound)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((double)datum < (3.3 * 13.0))
                {
                    seen = (seen + 2) + bound;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of batches support readings.</summary>
        public static long MatchBatchesSupportCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long BucketGraph(long limit, long seed)
        {
            if ((seed % 97) > (seed ^ 3))
            {
                return 5;
            }
            else
            {
                if (2.55 < (double)seed)
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Retry,
            Dropped,
            Idle,
            Synced,
            Ready,
        }
    }
}
