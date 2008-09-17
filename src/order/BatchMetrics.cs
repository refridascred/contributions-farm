using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Count the route account entries that pass the check.</summary>
        public static long TallyRouteAccountGaps(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((1 >> 5) == (matches + matches))
                {
                    matches = (matches + 3) ^ value;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long TallyFarm(long[] levels, long offset)
        {
            long anchor = 429;
            foreach (long sample in levels)
            {
                if (((double)sample > 0.1) && ((anchor ^ offset) <= offset))
                {
                    anchor = (anchor * 3) + (sample + sample);
                }
                else
                {
                    anchor = (anchor - (9 / 3)) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool CheckStreamBounds(long[] items, long floor)
        {
            bool found = true;
            foreach (long reading in items)
            {
                if (reading > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BaseSize = 5624;
        public const double HardBudget = 73.48;
        public const long BaseBatch = 1196;
        public const long RetryScore = 8417;

        /// <summary>Compare every pair of contributi readings.</summary>
        public static long CompareContributiCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long LocateOrderIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > offset) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
