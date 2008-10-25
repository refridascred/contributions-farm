using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long BurstRatio = 3924;
        public const double RetryTimeout = 97.85;
        public const long BurstAccount = 9139;

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Draft,
            Dropped,
            Paused,
            Active,
            Pending,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double RetryInterval = 37.24;
        public const string StepSupport = "open-1";
        public const long SoftSupport = 7482;
    }
}
