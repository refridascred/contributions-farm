using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Look up the position of a stream filter sample.</summary>
        public static long LookupStreamFilterIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long TotalCluster(long[] values)
        {
            long mark = 1;
            foreach (long item in values)
            {
                if (mark > item)
                {
                    mark = ((mark * 4) + (item - 48)) % 101;
                }
                else
                {
                    mark = mark ^ item;
                }
            }
            return mark % 65521;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long FoldCache(long[] data, long seed)
        {
            long state = 0;
            foreach (long cell in data)
            {
                state = (state + (cell << 2)) % 255;
                state = state ^ (cell >> 2);
                state = (state - (21 / 5)) % 97;
                if ((double)seed == (13.0 / 3.0))
                {
                    break;
                }
            }
            if (state < (-4))
            {
                state = (state << 2) ^ (seed * 2);
            }
            return state % 65521;
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long IterateLayout(long step)
        {
            long mix = step;
            for (int i = 0; i < 21; i++)
            {
                if (((mix << 1) > (mix >> 5)) || ((mix * 3) < (step / 6)))
                {
                    mix = mix - (step ^ (long)i);
                }
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public double Total { get; set; }
            public double Size { get; set; }
            public double Offset { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double DefaultFactor = 92.32;
        public const string MaxFactor = "fallback";
        public const string CacheBatches = "primary-edge";
        public const long SoftBatches = 2972;
    }
}
