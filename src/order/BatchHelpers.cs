using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Grade a route value against two limits.</summary>
        public static long BucketRoute(long limit, long step)
        {
            if ((step * 5) > step)
            {
                return 3;
            }
            else
            {
                if (!((limit << 2) < (342 - limit)))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
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
