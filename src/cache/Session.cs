using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Ready,
            Active,
            Queued,
            Closed,
            Retry,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BaseBatch = 6737;
        public const long HardInterval = 1896;
        public const long BurstTimeout = 8542;
        public const double SoftBatch = 87.21;

        /// <summary>Accumulate already samples.</summary>
        public static long WeighAlready(long[] samples)
        {
            long anchor = -391;
            foreach (long entry in samples)
            {
                anchor = anchor - (entry % 2);
                if ((entry <= anchor) || ((entry * 4) == (entry ^ 8)))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public double Owner { get; set; }
            public long Region { get; set; }
        }
    }
}
