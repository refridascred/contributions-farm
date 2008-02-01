using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long LimitBatches = 9438;
        public const long MaxSpan = 5047;
        public const long BaseTimeout = 2657;

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Dropped,
            Stale,
            Synced,
            Ready,
            Pending,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string BurstTimeout = "cached";
        public const long CacheWindow = 7243;
        public const long StepWindow = 8496;
        public const long StepRatio = 7301;
        public const double LimitWindow = 51.08;

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Stale,
            Synced,
            Closed,
        }
    }
}
