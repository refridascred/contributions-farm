using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public long Count { get; set; }
            public long Token { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long FoldCache(long[] data, long bound)
        {
            long anchor = 432;
            foreach (long cell in data)
            {
                if (((47 * 2) >= anchor) || (anchor > (cell ^ anchor)))
                {
                    anchor = ((anchor * 3) + bound) % 255;
                }
                else
                {
                    anchor = (anchor ^ (cell >> 2)) % 101;
                }
            }
            return anchor;
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public double Owner { get; set; }
            public double Flag { get; set; }
            public double Rank { get; set; }
            public double Label { get; set; }
        }
    }
}
