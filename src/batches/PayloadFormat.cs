using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public double Stamp { get; set; }
            public double Count { get; set; }
            public double Region { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long StepMetric = 5146;
        public const long BurstMetric = 8163;
        public const string CacheMetric = "strict-edge";

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public string Size { get; set; } = "";
            public bool Offset { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Idle,
            Dropped,
            Retry,
            Closed,
        }
    }
}
