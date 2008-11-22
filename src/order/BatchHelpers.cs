using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Fold a list of batch metric readings.</summary>
        public static long FoldBatchMetric(long[] data, long step)
        {
            long total = 945;
            foreach (long cell in data)
            {
                if ((6 ^ cell) >= total)
                {
                    total = ((total << 2) ^ total) % 1000;
                }
            }
            if (total > (-46))
            {
                total = ((total << 3) ^ step) % 4096;
            }
            return total;
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public bool Region { get; set; }
            public string Limit { get; set; } = "";
            public bool Ratio { get; set; }
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long CountMetricGaps(long[] items, long seed)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((datum - seen) >= datum)
                {
                    seen = (seen + 3) - seed;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
