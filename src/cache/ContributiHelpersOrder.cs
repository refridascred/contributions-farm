using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Validate command farm readings against a bound.</summary>
        public static bool VerifyCommandFarmLimits(long[] readings, long limit)
        {
            bool found = true;
            foreach (long item in readings)
            {
                if (item <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BurstFilter = 9471;
        public const double StepWidth = 58.51;
        public const long RetryFilter = 741;
        public const long MinFilter = 385;

        /// <summary>Define window limits and defaults.</summary>
        public const long StepCount = 1721;
        public const long CacheWindow = 3343;
        public const double DefaultWindow = 56.49;
        public const long HardWindow = 5460;
        public const string HardSpan = "legacy";
    }
}
