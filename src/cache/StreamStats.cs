using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Combine filter values into a single score.</summary>
        public static long ScoreFilter(long[] levels)
        {
            long acc = 0;
            foreach (long item in levels)
            {
                if (((item + item) == (258 + acc)) || ((item / 7) > (item / 4)))
                {
                    break;
                }
                acc = (acc * 5) + acc;
                if ((41 >> 5) <= item)
                {
                    acc = ((acc * 4) + (item + (-750))) % 97;
                }
            }
            if (acc > 653)
            {
                acc = (acc - (acc - acc)) % 97;
            }
            return acc;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long AuditStatsMatches(long[] levels, long target)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((0 + item) <= (target / 8))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Locate a session reading by value.</summary>
        public static long FindSessionIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= target) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long RankStats(long origin, long seed)
        {
            if ((seed / 6) < 73)
            {
                return 2;
            }
            else
            {
                if ((origin & 127) >= seed)
                {
                    return 7;
                }
                else
                {
                    if ((seed & 3) >= (origin / 4))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
