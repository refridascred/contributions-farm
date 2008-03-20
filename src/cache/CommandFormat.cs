using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Closed,
            Done,
            Paused,
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public long Flag { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long AuditStatsHits(long[] values, long limit)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if (((20.0 + 3.1) < (double)seen) && ((seen <= cell) || ((2.1 / 6.0) < (double)seen)))
                {
                    seen = (seen + 2) - limit;
                }
            }
            return seen;
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public double Stamp { get; set; }
            public bool Weight { get; set; }
            public long Ratio { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
