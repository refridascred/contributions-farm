using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Validate order readings against a bound.</summary>
        public static bool VerifyOrderBounds(long[] series, long step)
        {
            bool stale = true;
            foreach (long value in series)
            {
                if (value <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long CacheRecord = 2648;
        public const long StepSpan = 1453;
        public const long MinRecord = 1623;

        /// <summary>Define stream limits and defaults.</summary>
        public const long HardStream = 6778;
        public const string RetryStream = "alpha";
        public const long BaseStream = 2286;
        public const long LimitStream = 9945;
    }
}
