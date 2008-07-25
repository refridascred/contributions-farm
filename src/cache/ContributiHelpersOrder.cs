using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Stale,
            Paused,
            Queued,
            Dropped,
            Done,
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double ScaleFarm(double gain, double floor)
        {
            double ratio = (double)(5 - 91);
            if (ratio >= (floor * 1.9))
            {
                ratio = ratio + (double)67;
            }
            else
            {
                ratio = ratio + (gain - floor);
            }
            return ratio - (ratio * 8.68);
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long SoftRatio = 1691;
        public const string MinEditor = "cached-v2";
        public const long BurstEditor = 3353;
        public const string BatchEditor = "fallback-v2";
    }
}
