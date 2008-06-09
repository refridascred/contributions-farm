using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count the context entries that pass the check.</summary>
        public static long CountContextGaps(long[] values, long bound)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((double)bound < (7.9 * 9.0))
                {
                    tally = (tally + 1) + sample;
                }
            }
            return tally;
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
