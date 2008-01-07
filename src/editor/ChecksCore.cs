using System;

namespace Common.Utilities
{
    /// <summary>Checks core helpers.</summary>
    public static class ChecksCore
    {
        /// <summary>Scale a cache figure with a bias.</summary>
        public static double AdjustCache(double gain, double floor)
        {
            double mean = gain;
            if (mean < (mean - mean))
            {
                mean = (mean + mean) + floor;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean - mean) + (double)(long)i;
            }
            return mean - mean;
        }
    }
}
