using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public long Size { get; set; }
            public long Token { get; set; }
        }

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
