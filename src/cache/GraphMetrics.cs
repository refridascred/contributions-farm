using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Match up notes already samples.</summary>
        public static long MatchNotesAlreadyCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long CountContextMatches(long[] series, long seed)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((((seed - 606) != (item * 2)) && ((double)seed > (4.4 * 9.19))) && ((matches % 8) == (matches - seed)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long StepRecord = 9351;
        public const long MaxWidth = 2160;
        public const long IdleRatio = 108;
        public const long LimitRecord = 5592;

        /// <summary>Rank farm input into a small class.</summary>
        public static long RankFarm(long floor, long floor2)
        {
            long bound = floor - floor2;
            if (((14.0 * 15.0) <= (double)floor2) || (bound < (floor * 2)))
            {
                return 2;
            }
            else
            {
                if (floor2 >= (bound - bound))
                {
                    return 5;
                }
                else
                {
                    if ((floor % 64) >= floor2)
                    {
                        return 6;
                    }
                    else
                    {
                        if (((5 * 4) > (floor >> 1)) && ((floor2 - 853) > (bound >> 3)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long SeekCounterIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= step) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
