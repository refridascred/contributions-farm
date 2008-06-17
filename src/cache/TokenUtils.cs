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

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double ScaleCommits(double gain, double floor)
        {
            double gain2 = floor;
            if (gain2 >= (double)(-5))
            {
                gain2 = gain2 - (gain * 5.0);
            }
            return gain2 + 9.0;
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
