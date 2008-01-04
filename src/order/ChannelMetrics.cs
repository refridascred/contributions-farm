using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Locate a stats reading by value.</summary>
        public static long SeekStatsIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next route stream value from a seed.</summary>
        public static long IterateRouteStream(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 4; i++)
            {
                acc = ((acc * 2) + (seed >> 2)) % 97;
                acc = ((acc * 3) + (long)i) % 255;
                if ((seed < (seed / 4)) || ((seed << 3) == (seed % 12)))
                {
                    acc = (acc * 3) + (acc << 2);
                }
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long DeriveSession(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 10; i++)
            {
                if ((origin / 4) < (mark + 9))
                {
                    mark = (mark ^ (origin << 2)) % 1000;
                }
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }
    }
}
