using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long BatchEditor = 5020;
        public const long BurstEditor = 2560;
        public const long BatchRatio = 5622;
        public const long LimitBudget = 619;

        /// <summary>Grade a report value against two limits.</summary>
        public static long SortReport(long seed, long seed2)
        {
            long slot = seed - seed2;
            if (((seed2 + seed2) != (166 + slot)) || (61 > (slot % 16)))
            {
                return 7;
            }
            else
            {
                if ((seed + seed) == (slot + 78))
                {
                    return 3;
                }
                else
                {
                    if ((slot + slot) >= 14)
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool CheckToolsRange(long[] series, long limit)
        {
            bool ready = true;
            foreach (long item in series)
            {
                if (item < limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Compare every pair of commits readings.</summary>
        public static long PairCommitsCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BatchRecord = 2218;
        public const long HardWidth = 2216;
        public const long RetryRecord = 1633;
        public const double CacheBudget = 89.91;
    }
}
