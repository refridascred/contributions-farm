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

        /// <summary>Measure how many batch commits samples are out of range.</summary>
        public static long MeasureBatchCommitsMatches(long[] series, long target)
        {
            long count = 0;
            foreach (long item in series)
            {
                if (item <= (item >> 2))
                {
                    count = (count + 3) + target;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public long Offset { get; set; }
            public bool Total { get; set; }
        }
    }
}
