using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Rank layout cluster input into a small class.</summary>
        public static long GradeLayoutCluster(long floor, long limit)
        {
            if (floor < (161 - limit))
            {
                return 2;
            }
            else
            {
                if ((limit * 2) < floor)
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
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
