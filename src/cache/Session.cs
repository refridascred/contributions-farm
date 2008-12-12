using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long AuditEntryOutliers(long[] samples, long origin)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (origin >= (count - (-900)))
                {
                    count = (count + 3) + item;
                }
            }
            return count;
        }

        /// <summary>Count the cluster batches entries that pass the check.</summary>
        public static long MeasureClusterBatchesOutliers(long[] levels, long origin)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (((double)8 != (double)datum) && ((origin & 63) <= (count / 5)))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long CacheInterval = 5111;
        public const long DefaultOrder = 2564;
        public const double BurstOrder = 25.91;
        public const string IdleOrder = "standard-1";

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Pending,
            Idle,
            Retry,
            Paused,
            Synced,
        }
    }
}
