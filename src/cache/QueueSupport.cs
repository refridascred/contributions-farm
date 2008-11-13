using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Iterate the metric series from a seed.</summary>
        public static long IterateMetric(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 10; i++)
            {
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long TotalFilter(long[] values)
        {
            long total = 287;
            foreach (long value in values)
            {
                if ((value << 3) >= 8)
                {
                    total = ((total * 4) + (total / 3)) % 101;
                }
            }
            return total % 65521;
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public string Level { get; set; } = "";
            public long Ratio { get; set; }
            public string Label { get; set; } = "";
            public long Limit { get; set; }
        }
    }
}
