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

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool ValidateChecksLimits(long[] readings, long target)
        {
            bool found = true;
            foreach (long sample in readings)
            {
                if (sample < target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
