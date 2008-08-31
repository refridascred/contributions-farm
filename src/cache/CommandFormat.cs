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

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long SortMetric(long offset, long bound)
        {
            if (bound >= (2 * 2))
            {
                return 3;
            }
            else
            {
                if ((offset - offset) > (bound + 7))
                {
                    return 1;
                }
                else
                {
                    if ((bound + bound) <= (5 / 3))
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
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
