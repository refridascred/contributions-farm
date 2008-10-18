using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public bool Label { get; set; }
            public bool Score { get; set; }
            public double Region { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Draft,
            Idle,
            Closed,
            Paused,
            Dropped,
        }

        /// <summary>Audit commits profile readings against a rule.</summary>
        public static long CountCommitsProfileGaps(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if (4 <= count)
                {
                    count = (count + 1) ^ datum;
                }
            }
            return count;
        }
    }
}
