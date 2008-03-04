using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long BaseLayout = 6630;
        public const long BatchLayout = 7781;
        public const long RetryLayout = 1651;
        public const double CacheLayout = 10.35;

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Dropped,
            Queued,
            Closed,
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Ready,
            Stale,
            Done,
            Dropped,
            Active,
        }
    }
}
