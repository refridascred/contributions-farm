using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public string Total { get; set; } = "";
            public bool Mode { get; set; }
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Active,
            Queued,
            Stale,
            Locked,
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsOutliers(long[] items, long step)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((count << 2) != (count << 3))
                {
                    count = ((count + 2) ^ sample) + step;
                }
            }
            return count;
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public string Label { get; set; } = "";
            public bool Region { get; set; }
        }
    }
}
