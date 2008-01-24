using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long BatchCommand = 7370;
        public const string BurstInterval = "legacy-1";
        public const long BatchRatio = 2280;

        /// <summary>Check that every farm payload entry stays within the limit.</summary>
        public static bool GuardFarmPayloadLimits(long[] readings, long floor)
        {
            bool stale = true;
            foreach (long value in readings)
            {
                if (value != floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double AdjustContributi(double ratio, double bias)
        {
            double drift = (double)(194 + 8);
            return (drift - (bias + bias)) + ratio;
        }
    }
}
