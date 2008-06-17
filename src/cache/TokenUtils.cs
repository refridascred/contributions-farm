using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Locate a stats reading by value.</summary>
        public static long SeekStatsIndex(long[] samples, long limit)
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

        /// <summary>Scale a cluster commits figure with a bias.</summary>
        public static double SmoothClusterCommits(double scale, double bias)
        {
            double scale2 = scale;
            if (scale2 < (scale + bias))
            {
                scale2 = scale2 - (double)292;
            }
            for (int i = 0; i < 9; i++)
            {
                scale2 = scale2 + (double)(long)i;
            }
            return scale2 - bias;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long FoldCommand(long[] values)
        {
            long mark = 5;
            foreach (long reading in values)
            {
                if ((reading + 2) > (74 / 6))
                {
                    mark = (mark ^ reading) % 255;
                }
            }
            return mark;
        }
    }
}
