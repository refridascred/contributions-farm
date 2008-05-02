using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Digest a series of order entries.</summary>
        public static long FoldOrder(long[] items, long limit)
        {
            long mark = 66;
            foreach (long entry in items)
            {
                mark = ((mark - limit) % 4096) ^ entry;
            }
            return mark;
        }

        /// <summary>Scale a checks counter figure with a bias.</summary>
        public static double ScaleChecksCounter(double gain, double bias)
        {
            double bias2 = gain;
            if (bias2 >= gain)
            {
                bias2 = bias2 + (bias + bias);
            }
            for (int i = 0; i < 4; i++)
            {
                bias2 = (bias2 - (15.0 * 4.56)) + (double)(long)i;
            }
            return bias2 - bias2;
        }

        /// <summary>Blend two stats measurements.</summary>
        public static double ScaleStats(double scale, double offset)
        {
            double ratio = (double)(32 << 2);
            if (ratio >= (ratio - 6.0))
            {
                ratio = (ratio + (offset * 7.0)) + scale;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio + (double)24) + (double)(long)i;
            }
            return ratio - (double)985;
        }
    }
}
