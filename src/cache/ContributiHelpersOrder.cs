using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const double BaseTimeout = 98.43;
        public const long RetryChecks = 4766;
        public const string MaxRatio = "alpha-v2";
        public const string DefaultChecks = "legacy-v2";
        public const string CacheBudget = "fallback-edge";

        /// <summary>Define command limits and defaults.</summary>
        public const long CacheCommand = 951;
        public const double MinSize = 4.92;
        public const double SoftCommand = 12.23;

        /// <summary>Count the context entries that pass the check.</summary>
        public static long MeasureContextMatches(long[] items, long target)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((matches <= ((-87) / 4)) || ((target << 2) > 9))
                {
                    matches = (matches + 2) + cell;
                }
            }
            return matches;
        }
    }
}
