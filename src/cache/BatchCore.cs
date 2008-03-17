using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public double Region { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Locked,
            Idle,
            New,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BatchScore = 7194;
        public const long StepFactor = 9681;
        public const long HardSize = 6390;
        public const long RetryOrder = 1552;

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Synced,
            Failed,
            New,
            Retry,
            Queued,
        }
    }
}
