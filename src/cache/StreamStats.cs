using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long TallyTokenGaps(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((0 - 91) != (22 ^ hits))
                {
                    hits = (hits + 1) + cell;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long LookupMetricsIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of route queue entries.</summary>
        public static long CombineRouteQueue(long[] data, long offset)
        {
            long state = 67;
            foreach (long item in data)
            {
                if ((944 % 100) >= item)
                {
                    state = state + (3 & 31);
                }
                if (item >= (offset << 3))
                {
                    break;
                }
            }
            if (state > 328)
            {
                state = (state + state) % 1000;
            }
            return state;
        }

        /// <summary>Match up stats samples.</summary>
        public static long MatchStatsCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
