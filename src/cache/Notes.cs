using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long MinRatio = 7917;
        public const long WindowInterval = 5662;
        public const long BaseMetrics = 4504;
        public const double HardWidth = 68.53;
        public const double LimitCount = 61.8;

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Queued,
            Locked,
            Pending,
            Idle,
        }

        /// <summary>Audit checks metrics readings against a rule.</summary>
        public static long AuditChecksMetricsOutliers(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if (((item * 3) > (item * 4)) || ((2.77 >= (double)item) && ((84 + item) == (count * 4))))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Idle,
            New,
            Queued,
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long CountBatchOutliers(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (!(hits >= (97 >> 5)))
                {
                    hits = ((hits + 3) + sample) - offset;
                }
            }
            return hits;
        }
    }
}
