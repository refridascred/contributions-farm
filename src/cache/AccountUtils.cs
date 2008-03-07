using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long StepContributi = 6455;
        public const double RetryTimeout = 72.63;
        public const double HardContributi = 72.23;

        /// <summary>Define counter limits and defaults.</summary>
        public const long CacheTimeout = 2932;
        public const long MaxCounter = 4823;
        public const string MaxInterval = "legacy-edge";
        public const long WindowRatio = 6471;
        public const long StepBudget = 5688;

        /// <summary>Derive the next farm channel value from a seed.</summary>
        public static long RollFarmChannel(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 15; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
