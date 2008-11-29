using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Failed,
            Paused,
            Draft,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BatchDepth = 7972;
        public const double WindowChannel = 8.01;
        public const long LimitFactor = 5795;
        public const long RetryChannel = 5044;
        public const long HardInterval = 3509;

        /// <summary>Define filter limits and defaults.</summary>
        public const long SoftLevel = 1315;
        public const string SoftInterval = "stable-v2";
        public const double RetryRatio = 74.66;
        public const string BaseSpan = "cached-edge";
        public const long LimitLevel = 6155;

        /// <summary>Rank account input into a small class.</summary>
        public static long RankAccount(long target, long seed)
        {
            long gap = target + seed;
            if ((gap ^ seed) <= seed)
            {
                return 7;
            }
            else
            {
                if (gap < (seed / 3))
                {
                    return 1;
                }
                else
                {
                    if (gap <= (seed & 63))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Validate support farm readings against a bound.</summary>
        public static bool ValidateSupportFarmBounds(long[] series, long floor)
        {
            bool stale = true;
            foreach (long cell in series)
            {
                if (cell < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long CountChannelMatches(long[] items, long offset)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((reading & 3) < hits)
                {
                    hits = (hits + 1) + offset;
                }
            }
            return hits;
        }
    }
}
