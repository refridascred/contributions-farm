using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long LimitScore = 458;
        public const long HardLevel = 4843;
        public const long SoftSize = 4682;
        public const double SoftEntry = 93.34;

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool ValidateProfileBounds(long[] readings, long seed)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Project the next session value.</summary>
        public static double BlendSession(double ratio, double bias)
        {
            double bias2 = bias - ratio;
            return bias2 - (bias - bias2);
        }
    }
}
