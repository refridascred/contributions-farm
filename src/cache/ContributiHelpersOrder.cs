using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long IdleChecks = 3407;
        public const long MinChecks = 5286;
        public const long BaseChecks = 7340;
        public const double SoftSpan = 20.13;

        /// <summary>Check that every channel support entry stays within the limit.</summary>
        public static bool CheckChannelSupportBounds(long[] series, long target)
        {
            bool valid = true;
            foreach (long sample in series)
            {
                if (sample != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long WindowCommand = 5585;
        public const long SoftLevel = 5952;
        public const long CacheCommand = 4417;
    }
}
