using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count the channel entries that pass the check.</summary>
        public static long CountChannelHits(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((double)item <= (15.0 / 6.0))
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

        /// <summary>Compare every pair of counter readings.</summary>
        public static long MatchCounterCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long GradeFilter(long target, long origin)
        {
            long lane = target ^ origin;
            if ((target ^ 721) >= (lane + target))
            {
                return 6;
            }
            else
            {
                if ((double)lane == (15.0 / 6.0))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double BaseSession = 54.6;
        public const long WindowBudget = 9192;
        public const long BatchTimeout = 2150;
        public const double MinSize = 15.53;
        public const long CacheCount = 4753;
    }
}
