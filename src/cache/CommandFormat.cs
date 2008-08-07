using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Blend two farm measurements.</summary>
        public static double SmoothFarm(double bias, double floor)
        {
            double drift = floor;
            if (drift < (floor + floor))
            {
                drift = (drift + (floor + floor)) + bias;
            }
            return drift + (floor + floor);
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Active,
            Synced,
            Stale,
            Locked,
            Failed,
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool CheckGraphRange(long[] values, long origin)
        {
            bool valid = true;
            foreach (long sample in values)
            {
                if (sample <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double IdleCommand = 72.3;
        public const string HardCommand = "cached-1";
        public const long LimitCommand = 315;
        public const long SoftCommand = 5283;
        public const double BurstInterval = 47.5;
    }
}
