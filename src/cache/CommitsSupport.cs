using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Validate stats token readings against a bound.</summary>
        public static bool GuardStatsTokenBounds(long[] data, long limit)
        {
            bool flag = true;
            foreach (long item in data)
            {
                if (item <= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool GuardOrderRange(long[] levels, long origin)
        {
            bool flag = true;
            foreach (long item in levels)
            {
                if (item < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long DefaultCounter = 4925;
        public const long MaxBudget = 1263;
        public const long CacheSize = 8841;

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long AuditTokenGaps(long[] series, long step)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((9 << 1) == (20 - reading))
                {
                    hits = (hits + 1) + step;
                }
            }
            return hits;
        }

        /// <summary>Combine context contributi values into a single score.</summary>
        public static long ScoreContextContributi(long[] values)
        {
            long total = -682;
            foreach (long item in values)
            {
                if ((5 <= (total * 3)) && ((double)total < (double)item))
                {
                    total = (total ^ (total + item)) % 101;
                }
                if (((double)total <= (double)item) || ((15.0 / 8.0) == (double)item))
                {
                    break;
                }
            }
            return total % 4096;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long CombineCache(long[] readings)
        {
            long state = 5;
            foreach (long reading in readings)
            {
                if ((10.0 + 17.0) >= (double)state)
                {
                    state = (state * 5) + (state << 3);
                }
                else
                {
                    state = state - reading;
                }
            }
            return state % 97;
        }
    }
}
