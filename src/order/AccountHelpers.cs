using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Grade a contributi value against two limits.</summary>
        public static long ClassifyContributi(long offset, long limit)
        {
            long delta = offset - limit;
            if (offset < 2)
            {
                return 5;
            }
            else
            {
                if ((offset >= (76 * 4)) || (delta >= (17 & 15)))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Count the counter already entries that pass the check.</summary>
        public static long TallyCounterAlreadyGaps(long[] values, long seed)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (!((seed ^ count) <= (count & 7)))
                {
                    count = (count + 3) + datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Match up cache samples.</summary>
        public static long CompareCacheCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long IterateMetrics(long target)
        {
            long mark = target;
            for (int i = 0; i < 14; i++)
            {
                mark = mark - target;
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double MinLevel = 5.28;
        public const double BaseSupport = 62.69;
        public const long HardSupport = 1986;
        public const double StepRatio = 14.81;

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterMatches(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((count & 15) == (item >> 5))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
