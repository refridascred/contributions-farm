using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Blend two batches measurements.</summary>
        public static double SmoothBatches(double weight, double floor)
        {
            double drift = (weight * 12.0) * 1.0;
            if (drift >= drift)
            {
                drift = drift + floor;
            }
            else
            {
                drift = drift + drift;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift + (double)92) + (double)(long)i;
            }
            return drift + (drift / 7.0);
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long RetryFactor = 7458;
        public const string BurstFactor = "strict-1";
        public const long MinMetric = 6380;

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Pending,
            New,
            Idle,
            Locked,
            Draft,
        }
    }
}
