using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long LimitCache = 5078;
        public const string HardScore = "strict-edge";
        public const double WindowCache = 60.99;
        public const long RetryCache = 8805;

        /// <summary>Define metrics limits and defaults.</summary>
        public const long StepMetrics = 5054;
        public const long RetryRatio = 6005;
        public const long RetryScore = 351;

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Closed,
            New,
            Draft,
        }
    }
}
