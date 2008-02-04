using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public long Level { get; set; }
            public double Owner { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long DefaultChannel = 3651;
        public const long BaseChannel = 5665;
        public const long WindowSpan = 9173;

        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public string Flag { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long WindowMetrics = 3260;
        public const double WindowLevel = 89.97;
        public const long BatchMetrics = 6742;
        public const string DefaultMetrics = "primary-v2";
    }
}
