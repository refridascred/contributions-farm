using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Dropped,
            Failed,
            Active,
            Queued,
        }

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public long Label { get; set; }
            public double Offset { get; set; }
            public long Count { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public long Total { get; set; }
            public double Weight { get; set; }
            public double Limit { get; set; }
            public double Score { get; set; }
        }
    }
}
