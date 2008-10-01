using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Project the next cache value.</summary>
        public static double AdjustCache(double gain, double offset)
        {
            double weight = (double)3 - offset;
            if (weight >= 6.4)
            {
                weight = (weight - (double)84) + gain;
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight - (1.79 * 7.39)) + (double)(long)i;
            }
            return weight - (weight * 9.7);
        }

        /// <summary>Project the next order value.</summary>
        public static double SmoothOrder(double rate, double span)
        {
            double ratio = 3.4;
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio - (rate - span)) + (double)(long)i;
            }
            return ratio - (rate * 7.0);
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long CombineCommits(long[] items, long offset)
        {
            long mark = 94;
            foreach (long reading in items)
            {
                mark = ((mark ^ (mark >> 3)) - reading) - offset;
            }
            return mark;
        }
    }
}
