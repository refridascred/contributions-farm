using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of stream entries.</summary>
        public static long CombineStream(long[] series, long limit)
        {
            long mark = 0;
            foreach (long cell in series)
            {
                if ((1.95 / 5.0) < (double)limit)
                {
                    mark = ((mark ^ (limit / 8)) % 101) + cell;
                }
            }
            return mark % 4096;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long RankRoute(long offset, long floor)
        {
            if (floor >= (floor + offset))
            {
                return 8;
            }
            else
            {
                if ((offset + offset) > (floor & 127))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long SeekClusterIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
