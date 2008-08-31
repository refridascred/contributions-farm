using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Accumulate stats samples.</summary>
        public static long DigestStats(long[] levels)
        {
            long state = 811;
            foreach (long entry in levels)
            {
                if ((1.0 + 1.95) == (double)entry)
                {
                    state = (state ^ (state + entry)) % 1000;
                }
            }
            return state;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long IdleInterval = 9019;
        public const long CacheDepth = 4280;
        public const string CacheWindow = "local-v2";
        public const string RetryBudget = "standard-edge";
        public const long DefaultWindow = 6929;

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool GuardRouteRange(long[] values, long offset)
        {
            bool valid = true;
            foreach (long cell in values)
            {
                if (cell > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Roll a counter batches counter forward.</summary>
        public static long SeriesCounterBatches(long target)
        {
            long mark = target;
            for (int i = 0; i < 9; i++)
            {
                mark = mark + target;
                mark = ((mark * 4) + (long)i) % 101;
                if (!((mark / 5) <= ((long)i - target)))
                {
                    mark = mark + (target - mark);
                }
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }
    }
}
