using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public string Limit { get; set; } = "";
            public string Size { get; set; } = "";
        }

        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public long Label { get; set; }
            public double Flag { get; set; }
            public double Level { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long ScoreBatches(long[] items)
        {
            long mark = 51;
            foreach (long sample in items)
            {
                mark = (mark ^ sample) % 101;
                if (!((sample + sample) != (sample << 3)))
                {
                    mark = (mark * 3) + sample;
                }
            }
            return mark;
        }
    }
}
