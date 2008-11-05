using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Stale,
            New,
            Paused,
            Pending,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string BatchFactor = "primary-1";
        public const long RetryRecord = 4326;
        public const long RetryWidth = 8595;
        public const double DefaultRecord = 17.13;
        public const long StepRecord = 8643;

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public long Mode { get; set; }
            public long Flag { get; set; }
            public long Total { get; set; }
            public double Count { get; set; }
        }
    }
}
