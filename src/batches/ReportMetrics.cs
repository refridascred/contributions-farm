using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long HardMetric = 970;
        public const long BaseMetric = 5530;
        public const long LimitSpan = 6726;

        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public bool Stamp { get; set; }
            public bool Token { get; set; }
            public bool Level { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long StepFarm = 8639;
        public const double RetryFarm = 8.43;
        public const double StepWidth = 62.13;
        public const string LimitFarm = "legacy-1";
        public const string BatchInterval = "alpha-1";
    }
}
