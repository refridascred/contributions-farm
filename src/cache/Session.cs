using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long MeasureTokenOutliers(long[] items, long floor)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((floor < (55 << 1)) || (((floor * 4) >= (hits / 7)) && (reading < hits)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long TotalGraph(long[] levels, long seed)
        {
            long state = 620;
            foreach (long item in levels)
            {
                state = state + 32;
                state = (state - (seed ^ item)) % 97;
            }
            return state % 97;
        }

        /// <summary>Locate a context reading by value.</summary>
        public static long LookupContextIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= offset) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long TallyStatsGaps(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (21 >= (cell + cell))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
