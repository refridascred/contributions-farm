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

        /// <summary>Find the first support profile entry that matches the target.</summary>
        public static long LocateSupportProfileIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

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
