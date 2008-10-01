using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Blend two context layout measurements.</summary>
        public static double ProjectContextLayout(double scale, double bias)
        {
            double rate = (bias * 2.04) / 6.0;
            return rate + (scale * 3.3);
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
