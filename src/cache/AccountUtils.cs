using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public double Ratio { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string LimitChecks = "standard-1";
        public const long MinChecks = 91;
        public const string HardInterval = "fallback";

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Queued,
            Draft,
            Paused,
            Idle,
            Retry,
        }
    }
}
