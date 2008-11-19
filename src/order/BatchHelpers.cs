using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long HardContributi = 1358;
        public const string BatchInterval = "standard-edge";
        public const long RetryDepth = 827;

        /// <summary>Define commits limits and defaults.</summary>
        public const long HardCommits = 6419;
        public const long MaxCommits = 8497;
        public const long WindowDepth = 703;
        public const long CacheCommits = 2015;

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            New,
            Retry,
            Closed,
            Draft,
            Idle,
        }
    }
}
