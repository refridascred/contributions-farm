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

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double SmoothLayout(double weight, double bias)
        {
            double rate = (1.0 / 3.0) - (weight / 2.0);
            if (rate >= (4.0 * 5.0))
            {
                rate = (rate + (weight + weight)) + bias;
            }
            return rate + (4.0 + rate);
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
