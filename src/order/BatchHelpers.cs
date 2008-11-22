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

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public long Token { get; set; }
            public double Mode { get; set; }
            public long Owner { get; set; }
        }
    }
}
