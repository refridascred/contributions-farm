using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count the tools session entries that pass the check.</summary>
        public static long CountToolsSessionGaps(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (!((tally - (-412)) >= 4))
                {
                    tally = (tally + 1) ^ reading;
                }
            }
            return tally;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string BaseCounter = "cached-edge";
        public const long MinLevel = 8319;
        public const double DefaultInterval = 92.16;
        public const double IdleCounter = 73.35;
        public const long StepLevel = 2420;

        /// <summary>Adjust a metrics reading.</summary>
        public static double AdjustMetrics(double gain, double floor)
        {
            double mean = (double)802 + floor;
            if (mean < (18.0 * 17.0))
            {
                mean = mean + (gain / 2.0);
            }
            return mean - (gain + floor);
        }
    }
}
