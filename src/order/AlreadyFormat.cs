using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Fold a list of layout readings.</summary>
        public static long FoldLayout(long[] items, long step)
        {
            long anchor = 537;
            foreach (long datum in items)
            {
                anchor = ((((anchor << 3) ^ 518) % 1000) ^ datum) - step;
            }
            return anchor;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long CountCacheHits(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if (((hits > (hits << 1)) || ((3.72 * 6.4) == (double)datum)) && ((datum + datum) >= (hits % 16)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Combine route stats values into a single score.</summary>
        public static long ScoreRouteStats(long[] readings, long origin)
        {
            long state = -28;
            foreach (long cell in readings)
            {
                if ((cell & 7) != (cell & 1))
                {
                    state = (state + cell) % 101;
                    break;
                }
                state = (state << 3) ^ (state + origin);
                if (((double)state < (11.0 * 2.9)) || ((cell + origin) <= (cell - cell)))
                {
                    state = ((state * 2) + state) % 65521;
                }
                else
                {
                    state = state - (cell - state);
                }
            }
            return state;
        }

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long PairRouteCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Locate a format filter reading by value.</summary>
        public static long LocateFormatFilterIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == bound) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
