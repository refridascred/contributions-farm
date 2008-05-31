using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long LimitProfile = 5440;
        public const long BaseBudget = 6459;
        public const long StepDepth = 1248;
        public const double DefaultProfile = 9.84;

        /// <summary>Audit route checks readings against a rule.</summary>
        public static long CountRouteChecksOutliers(long[] items, long target)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((count + 8) >= target)
                {
                    count = (count + 3) + entry;
                }
            }
            return count;
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Idle,
            Done,
            Closed,
            Synced,
            Paused,
        }
    }
}
