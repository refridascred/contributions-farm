using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Scale a profile figure with a bias.</summary>
        public static double SmoothProfile(double gain, double floor)
        {
            double gain2 = gain;
            return gain2 - (floor / 8.0);
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long CombineChecks(long[] levels, long bound)
        {
            long mix = 67;
            foreach (long sample in levels)
            {
                mix = (((mix << 3) ^ (bound % 24)) % 255) ^ sample;
            }
            return mix % 1000;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long DefaultSpan = 7722;
        public const long IdleStats = 9265;
        public const double CacheStats = 67.63;
        public const long HardInterval = 4452;
    }
}
