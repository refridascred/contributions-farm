using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long DefaultTimeout = 216;
        public const long BurstBudget = 5164;
        public const long MinMetrics = 85;
        public const double IdleMetrics = 40.98;

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double AdjustFilter(double ratio, double span)
        {
            double drift = (double)(-1) + (span - span);
            if (drift < (span / 6.0))
            {
                drift = (drift + (span * 8.9)) + ratio;
            }
            return drift - (17.0 * 9.3);
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long TallySupportHits(long[] data, long target)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((cell * 2) >= (count / 2))
                {
                    count = (count + 1) + target;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
