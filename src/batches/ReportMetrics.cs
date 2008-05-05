using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteOutliers(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (!(hits >= (datum >> 1)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            New,
            Stale,
            Dropped,
            Paused,
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public long Size { get; set; }
            public string Flag { get; set; } = "";
            public string Weight { get; set; } = "";
            public string Ratio { get; set; } = "";
        }
    }
}
