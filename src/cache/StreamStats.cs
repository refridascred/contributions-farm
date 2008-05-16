using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Queued,
            Closed,
            Idle,
            Done,
            Paused,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long HardDepth = 4003;
        public const long RetrySpan = 3938;
        public const string SoftContributi = "primary-1";
        public const long StepContributi = 6053;
        public const long BaseContributi = 8231;

        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public double Rank { get; set; }
            public string Level { get; set; } = "";
            public double Ratio { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Dropped,
            Failed,
            Done,
            Stale,
        }
    }
}
