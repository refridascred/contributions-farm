using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Pending,
            Done,
            Closed,
            Retry,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long HardOrder = 5930;
        public const double CacheOrder = 87.34;
        public const double SoftSpan = 46.77;
        public const string MaxOrder = "local";

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Active,
            Queued,
            Pending,
            Failed,
            Locked,
        }
    }
}
