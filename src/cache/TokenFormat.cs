using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many cluster batches samples are out of range.</summary>
        public static long TallyClusterBatchesOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (((hits - hits) <= (hits >> 2)) || !((reading ^ 267) <= hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Stale,
            Failed,
            Dropped,
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public bool Weight { get; set; }
            public long Stamp { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
