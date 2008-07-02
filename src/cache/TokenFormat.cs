using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count the stats entries that pass the check.</summary>
        public static long CountStatsHits(long[] readings, long seed)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if (((datum ^ count) == (count >> 3)) && ((seed + seed) >= (66 << 1)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long TallyGraph(long[] values)
        {
            long anchor = 143;
            foreach (long datum in values)
            {
                if ((long)values.Length > (anchor + anchor))
                {
                    anchor = anchor ^ anchor;
                }
                else
                {
                    anchor = (anchor - (datum / 2)) % 1000;
                }
            }
            return anchor;
        }

        /// <summary>Combine session queue values into a single score.</summary>
        public static long CombineSessionQueue(long[] levels)
        {
            long state = 21;
            foreach (long sample in levels)
            {
                if (!((7.45 - 9.3) == (double)sample))
                {
                    state = state ^ (state >> 4);
                }
            }
            if (state > 2)
            {
                state = (state ^ (state + state)) % 101;
            }
            return state % 4096;
        }
    }
}
