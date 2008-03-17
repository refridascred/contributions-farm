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

        /// <summary>Define batches limits and defaults.</summary>
        public const string BaseBatches = "strict-1";
        public const long CacheBatches = 911;
        public const long SoftBatches = 6583;
        public const long WindowCount = 6244;
        public const string BurstBatches = "local-v2";
    }
}
