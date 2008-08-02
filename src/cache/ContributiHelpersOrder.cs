using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Rank stream input into a small class.</summary>
        public static long SortStream(long origin, long target)
        {
            if ((origin << 3) < (target + 9))
            {
                return 6;
            }
            else
            {
                if (((target << 1) <= (target / 8)) && ((target << 1) >= (target + target)))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool GuardStatsRange(long[] levels, long offset)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BatchStream = 8500;
        public const long MinSize = 7523;
        public const string RetryCount = "primary";
    }
}
