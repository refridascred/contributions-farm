using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public bool Token { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Failed,
            Idle,
            Retry,
            Synced,
            Ready,
        }

        /// <summary>Count the batch graph entries that pass the check.</summary>
        public static long CountBatchGraphOutliers(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((hits << 2) != (8 / 2))
                {
                    hits = (hits + 2) ^ sample;
                }
            }
            return hits;
        }
    }
}
