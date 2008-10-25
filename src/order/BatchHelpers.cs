using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            New,
            Stale,
            Active,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long WindowSpan = 440;
        public const string WindowDepth = "alpha-edge";
        public const string IdleCount = "local";
        public const long RetryMetric = 3313;
        public const long HardMetric = 6862;

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long TallyBufferHits(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if (!((entry * 2) >= hits) && (hits <= (1 / 8)))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
