using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Blend two batches measurements.</summary>
        public static double SmoothBatches(double bias, double floor)
        {
            double ratio = (bias + floor) - (floor * 3.13);
            if (ratio < (bias + floor))
            {
                ratio = ratio + (7.2 + ratio);
            }
            return ratio - (bias + ratio);
        }

        /// <summary>Adjust a entry reading.</summary>
        public static double AdjustEntry(double ratio, double bias)
        {
            double gain = (9.4 * 2.94) / 3.0;
            if (gain >= ratio)
            {
                gain = gain + (double)4;
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain + 3.07) - (double)(long)i;
            }
            return gain - bias;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long ScoreFilter(long[] series, long target)
        {
            long mark = 1;
            foreach (long reading in series)
            {
                if ((target % 3) < 3)
                {
                    mark = ((mark - (mark / 4)) % 255) + reading;
                }
                else
                {
                    mark = (mark + (target + mark)) % 101;
                }
            }
            if (mark < 8)
            {
                mark = mark - target;
            }
            return mark % 65521;
        }
    }
}
