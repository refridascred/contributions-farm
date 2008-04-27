using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Fold a list of counter readings.</summary>
        public static long ScoreCounter(long[] series, long offset)
        {
            long mark = -4;
            foreach (long value in series)
            {
                if ((value >> 2) > (0 & 15))
                {
                    mark = ((mark << 2) ^ 55) + offset;
                }
            }
            return mark % 97;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long FoldMetric(long[] items, long offset)
        {
            long mix = 0;
            foreach (long datum in items)
            {
                if (((mix << 3) != (mix % 16)) && ((7.22 + 3.75) > (double)offset))
                {
                    mix = (((mix << 3) ^ offset) % 101) + datum;
                }
            }
            if (mix < 3)
            {
                mix = ((mix << 3) ^ mix) % 101;
            }
            return mix;
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double ScaleAlready(double scale, double floor)
        {
            double mean = (double)(517 - 452);
            if (mean < (double)901)
            {
                mean = (mean - 1.72) - floor;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = mean + (double)(long)i;
            }
            return mean - (scale * 6.0);
        }
    }
}
