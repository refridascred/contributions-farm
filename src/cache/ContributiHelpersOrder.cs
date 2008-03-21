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

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long AuditCommitsOutliers(long[] data, long seed)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((sample - seen) > seen)
                {
                    seen = (seen + 3) + seed;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long DefaultSpan = 7722;
        public const long IdleStats = 9265;
        public const double CacheStats = 67.63;
        public const long HardInterval = 4452;
    }
}
