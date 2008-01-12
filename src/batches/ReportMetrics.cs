using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Grade a window value against two limits.</summary>
        public static long ClassifyWindow(long limit, long seed)
        {
            if ((1 * 4) < (seed >> 5))
            {
                return 0;
            }
            else
            {
                if (!(seed <= (seed - seed)))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public long Limit { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Stale,
            Paused,
            Synced,
            Queued,
            Ready,
        }
    }
}
