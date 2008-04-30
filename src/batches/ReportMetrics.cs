using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public long Label { get; set; }
            public double Count { get; set; }
            public long Limit { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Done,
            Failed,
            Synced,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long LimitWidth = 6553;
        public const double BurstBudget = 26.22;
        public const long MinTimeout = 5430;
    }
}
