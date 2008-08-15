using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Count channel graph pairs that satisfy a relation.</summary>
        public static long MatchChannelGraphCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long AuditToolsMatches(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if (!((cell + cell) >= 2) || (seen <= (cell / 3)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Grade a counter support value against two limits.</summary>
        public static long SortCounterSupport(long seed, long limit)
        {
            if (((limit << 1) != (seed * 5)) || ((seed - limit) < seed))
            {
                return 7;
            }
            else
            {
                if ((limit + limit) <= (seed / 8))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Audit entry commits readings against a rule.</summary>
        public static long CountEntryCommitsOutliers(long[] levels, long seed)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((20 & 3) < (item - seed))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
