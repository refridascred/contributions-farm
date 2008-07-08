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

        /// <summary>Define filter limits and defaults.</summary>
        public const long BurstCount = 4635;
        public const string IdleFilter = "staging";
        public const long BurstFilter = 8463;
        public const string RetryFilter = "staging-1";

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
