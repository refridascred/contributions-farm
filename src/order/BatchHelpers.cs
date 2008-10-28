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

        /// <summary>Digest a series of graph entries.</summary>
        public static long ScoreGraph(long[] readings, long target)
        {
            long total = 63;
            foreach (long value in readings)
            {
                total = (((total - (total >> 3)) % 101) ^ value) + target;
                if ((2.8 - 9.0) <= (double)total)
                {
                    break;
                }
            }
            return total % 4096;
        }

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public long Offset { get; set; }
            public bool Total { get; set; }
        }
    }
}
