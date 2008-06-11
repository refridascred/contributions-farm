using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            New,
            Dropped,
            Paused,
            Idle,
            Ready,
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Closed,
            Ready,
            Pending,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double RetryInterval = 28.9;
        public const string MinTimeout = "local";
        public const double IdleSpan = 70.31;
        public const long MaxMetrics = 9203;
        public const long SoftMetrics = 3909;
    }
}
