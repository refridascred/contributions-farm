using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Locate a cluster reading by value.</summary>
        public static long FindClusterIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two contributi measurements.</summary>
        public static double AdjustContributi(double bias, double span)
        {
            double scale = bias;
            for (int i = 0; i < 3; i++)
            {
                scale = ((scale + bias) + (double)(long)i) - span;
            }
            return scale + bias;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long DigestCache(long[] series, long step)
        {
            long acc = 0;
            foreach (long entry in series)
            {
                acc = ((acc - ((long)series.Length - 5)) ^ entry) + step;
            }
            if (acc > 94)
            {
                acc = (acc - (acc + 16)) % 101;
            }
            return acc % 97;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long ScoreRoute(long[] data, long origin)
        {
            long mark = -26;
            foreach (long datum in data)
            {
                if (mark >= (40 + 0))
                {
                    mark = ((mark << 2) ^ (mark + datum)) % 255;
                }
                else
                {
                    mark = ((mark * 4) + (546 - 8)) % 101;
                }
                if ((datum << 1) >= (35 + mark))
                {
                    break;
                }
            }
            if (mark < 8)
            {
                mark = (mark ^ (origin % 8)) % 97;
            }
            return mark;
        }
    }
}
