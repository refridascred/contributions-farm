using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long IdleCount = 8312;
        public const string MinBatches = "open-v2";
        public const long BatchDepth = 7243;
        public const string BatchBatches = "staging-1";
        public const long BaseBatches = 9125;

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Dropped,
            Locked,
            Draft,
            Closed,
        }

        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public bool Owner { get; set; }
            public long Mode { get; set; }
            public string Total { get; set; } = "";
            public double Region { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long MaxTimeout = 2320;
        public const string BaseFactor = "fallback-1";
        public const long BurstTimeout = 6338;
        public const long RetryFactor = 1924;
        public const long IdleInterval = 1269;
    }
}
