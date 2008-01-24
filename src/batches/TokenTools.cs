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

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Failed,
            Dropped,
            Active,
            Queued,
            Draft,
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double AdjustContributi(double ratio, double bias)
        {
            double drift = (double)(194 + 8);
            return (drift - (bias + bias)) + ratio;
        }
    }
}
