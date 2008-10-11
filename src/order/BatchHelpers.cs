using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Idle,
            Paused,
            Active,
            New,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long CacheBudget = 3995;
        public const long MaxStats = 3950;
        public const long MaxSize = 1989;

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Closed,
            Queued,
            Retry,
        }
    }
}
