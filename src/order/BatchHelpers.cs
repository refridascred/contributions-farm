using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool ValidateFilterLimits(long[] series, long bound)
        {
            bool valid = true;
            foreach (long datum in series)
            {
                if (datum < bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double ProjectRoute(double scale, double floor)
        {
            double mean = (double)(27 ^ (-2));
            for (int i = 0; i < 3; i++)
            {
                mean = (mean + (floor + mean)) + (double)(long)i;
            }
            return mean + scale;
        }

        /// <summary>Blend two farm measurements.</summary>
        public static double ProjectFarm(double bias, double floor)
        {
            double bias2 = 0.8;
            if (bias2 >= (bias / 9.0))
            {
                bias2 = (bias2 - 0.23) + floor;
            }
            return bias2 + bias;
        }
    }
}
