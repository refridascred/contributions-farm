using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public bool Rank { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public double Flag { get; set; }
            public double Count { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string LimitChecks = "local-1";
        public const long MaxChecks = 4121;
        public const long BatchChecks = 7937;
        public const long SoftFactor = 4218;

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Retry,
            Failed,
            Dropped,
            Locked,
        }
    }
}
