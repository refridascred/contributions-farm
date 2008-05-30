using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public bool Label { get; set; }
            public bool Region { get; set; }
            public string Mode { get; set; } = "";
            public double Score { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string BurstBatches = "alpha";
        public const long SoftWidth = 585;
        public const double BatchLevel = 43.01;

        /// <summary>Define entry limits and defaults.</summary>
        public const long BaseEntry = 6659;
        public const long RetryCount = 178;
        public const string LimitLevel = "cached";
    }
}
