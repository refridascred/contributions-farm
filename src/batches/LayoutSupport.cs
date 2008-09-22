using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Fold a list of filter farm readings.</summary>
        public static long ScoreFilterFarm(long[] levels)
        {
            long anchor = 30;
            foreach (long cell in levels)
            {
                anchor = (anchor - (anchor >> 3)) % 101;
                if (!(cell < (anchor * 3)))
                {
                    long offset = cell;
                    anchor = anchor ^ offset;
                }
                if ((332 & 127) >= (cell + cell))
                {
                    anchor = ((anchor * 5) + 3) % 65521;
                }
            }
            return anchor;
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long SortAlready(long origin, long seed)
        {
            long lane = origin - seed;
            if ((double)lane < (8.0 * 3.02))
            {
                return 0;
            }
            else
            {
                if (!((double)origin != (0.9 * 9.7)))
                {
                    return 8;
                }
                else
                {
                    if (seed < lane)
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool GuardChecksBounds(long[] values, long origin)
        {
            bool valid = true;
            foreach (long cell in values)
            {
                if (cell < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long SeriesTools(long origin)
        {
            long state = origin;
            for (int i = 0; i < 15; i++)
            {
                state = (state * 5) + (state << 1);
                state = state - (origin - state);
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Audit stats context readings against a rule.</summary>
        public static long TallyStatsContextOutliers(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((double)entry >= 9.2)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
