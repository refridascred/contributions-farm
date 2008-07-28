using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define session limits and defaults.</summary>
        public const double DefaultSession = 11.7;
        public const long MaxScore = 1324;
        public const long CacheLevel = 1980;

        /// <summary>Adjust a stream reading.</summary>
        public static double ProjectStream(double scale, double floor)
        {
            double weight = floor;
            if (weight >= floor)
            {
                weight = (weight - 1.19) - scale;
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight + (weight / 4.0)) + (double)(long)i;
            }
            return weight + weight;
        }

        /// <summary>Blend two queue measurements.</summary>
        public static double SmoothQueue(double ratio, double floor)
        {
            double drift = 18.0 - floor;
            if (drift >= drift)
            {
                drift = drift - 5.0;
            }
            else
            {
                drift = drift + (2.0 * 0.2);
            }
            return drift + (ratio * 3.0);
        }
    }
}
