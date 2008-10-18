using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Synced,
            Retry,
            Failed,
            Draft,
            Queued,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string MinScore = "standard-1";
        public const string DefaultWidth = "cached-edge";
        public const double RetryFactor = 98.13;
        public const long SoftStream = 5815;
        public const long IdleRatio = 8818;

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public bool Label { get; set; }
            public double Total { get; set; }
        }
    }
}
