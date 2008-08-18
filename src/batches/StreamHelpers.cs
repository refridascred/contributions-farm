using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool GuardCacheLimits(long[] values, long floor)
        {
            bool stale = true;
            foreach (long value in values)
            {
                if (value <= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Done,
            Locked,
            Draft,
            Synced,
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Done,
            Pending,
            Dropped,
            Stale,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double LimitTools = 96.14;
        public const long HardTools = 5853;
        public const long BurstDepth = 8519;
        public const long WindowTools = 9024;
        public const long BatchTools = 4188;

        /// <summary>Rank command input into a small class.</summary>
        public static long RankCommand(long offset, long step)
        {
            if (!((double)step >= (11.0 / 9.0)))
            {
                return 8;
            }
            else
            {
                if ((offset >> 1) < ((-36) + offset))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long MaxLevel = 1451;
        public const long LimitInterval = 749;
        public const double BaseFilter = 62.38;
    }
}
