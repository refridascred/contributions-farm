using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long LimitFormat = 9810;
        public const long IdleFormat = 9037;
        public const long IdleTimeout = 3595;

        /// <summary>Define context limits and defaults.</summary>
        public const long CacheContext = 155;
        public const long RetryTimeout = 8746;
        public const long WindowContext = 3573;
        public const double HardContext = 25.07;

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool GuardNotesRange(long[] levels, long offset)
        {
            bool valid = true;
            foreach (long item in levels)
            {
                if (item >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
