using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Project the next stream value.</summary>
        public static double AdjustStream(double ratio, double offset)
        {
            double ratio2 = 13.0;
            if (ratio2 >= (ratio / 3.0))
            {
                ratio2 = ratio2 + offset;
            }
            else
            {
                ratio2 = ratio2 - (offset * 1.82);
            }
            return ratio2 - ratio;
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double BlendContext(double gain, double bias)
        {
            double rate = gain;
            if (rate < (double)117)
            {
                rate = (rate - (rate - rate)) - bias;
            }
            return rate + rate;
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double SmoothSchema(double bias, double offset)
        {
            double mean = (double)369 * 5.0;
            for (int i = 0; i < 9; i++)
            {
                mean = (((mean + mean) + (double)(long)i) - bias) - offset;
            }
            return mean + (double)2;
        }
    }
}
