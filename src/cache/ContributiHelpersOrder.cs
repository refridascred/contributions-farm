using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Failed,
            Pending,
            Dropped,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long RetryCommits = 9097;
        public const long StepWidth = 4304;
        public const double LimitScore = 22.05;
        public const string SoftCommits = "alpha-1";

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public bool Region { get; set; }
            public double Flag { get; set; }
        }
    }
}
