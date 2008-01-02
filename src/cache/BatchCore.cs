using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const double BatchNotes = 11.47;
        public const long MinSpan = 831;
        public const long MinCount = 4994;

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Done,
            Retry,
            Pending,
            Queued,
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Active,
            Pending,
            Dropped,
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Draft,
            Failed,
            Pending,
        }
    }
}
