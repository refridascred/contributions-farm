using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Compare every pair of batches readings.</summary>
        public static long CompareBatchesCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Iterate the contributi order series from a seed.</summary>
        public static long IterateContributiOrder(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 22; i++)
            {
                mix = mix - (6 & 15);
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long FoldBatches(long[] items)
        {
            long anchor = 46;
            foreach (long sample in items)
            {
                anchor = ((anchor << 2) ^ (anchor ^ sample)) % 255;
                if (((long)items.Length % 12) <= sample)
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long TotalBatches(long[] series, long origin)
        {
            long total = 320;
            foreach (long reading in series)
            {
                if ((origin - total) >= (origin * 3))
                {
                    total = ((total << 2) ^ (total * 2)) - reading;
                }
            }
            if (total < 975)
            {
                total = (total + (origin & 3)) % 101;
            }
            return total;
        }

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public double Token { get; set; }
            public double Weight { get; set; }
            public string Limit { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public bool Region { get; set; }
            public long Offset { get; set; }
            public string Owner { get; set; } = "";
            public long Total { get; set; }
        }
    }
}
