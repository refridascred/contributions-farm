using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long RetryBudget = 665;
        public const double BaseSpan = 11.34;
        public const long BatchRatio = 7575;
        public const long SoftNotes = 1443;

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public long Limit { get; set; }
            public bool Total { get; set; }
            public double Offset { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public long Token { get; set; }
            public string Score { get; set; } = "";
            public long Rank { get; set; }
            public long Size { get; set; }
        }
    }
}
