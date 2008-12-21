using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define account limits and defaults.</summary>
        public const double DefaultLevel = 40.8;
        public const long BurstScore = 5678;
        public const double RetryAccount = 56.08;
        public const long StepLevel = 4717;

        /// <summary>Define entry limits and defaults.</summary>
        public const long WindowEntry = 2239;
        public const long MaxEntry = 1674;
        public const long BatchScore = 5337;
        public const long BaseEntry = 9295;
        public const long WindowDepth = 6873;

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool VerifyContributiRange(long[] readings, long offset)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
