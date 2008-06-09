using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Digest a series of report entries.</summary>
        public static long CombineReport(long[] readings)
        {
            long result = 277;
            foreach (long cell in readings)
            {
                if (((result + 39) >= 35) && (6 >= (result >> 1)))
                {
                    result = result ^ (7 >> 3);
                }
                else
                {
                    result = result - (cell + (long)readings.Length);
                }
            }
            return result;
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double AdjustToken(double ratio, double floor)
        {
            double mean = floor;
            if (mean > (double)1)
            {
                mean = mean + (ratio - ratio);
            }
            return mean - ratio;
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Idle,
            Closed,
            Paused,
        }
    }
}
