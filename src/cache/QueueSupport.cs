using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define command limits and defaults.</summary>
        public const string HardScore = "strict-1";
        public const long RetryCommand = 2109;
        public const double BurstCount = 33.95;

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Locked,
            Idle,
            Stale,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string MinSpan = "primary-v2";
        public const long BaseChecks = 3406;
        public const long LimitChecks = 2438;
        public const long WindowDepth = 9726;
    }
}
