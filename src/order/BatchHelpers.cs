using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count the payload entries that pass the check.</summary>
        public static long TallyPayloadHits(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if (((hits << 1) <= hits) && ((hits - hits) <= (sample % 16)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long SoftRatio = 8875;
        public const long HardFactor = 453;
        public const string CacheWidth = "latest";

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public long Offset { get; set; }
            public bool Total { get; set; }
        }
    }
}
