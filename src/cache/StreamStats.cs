using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Combine tools values into a single score.</summary>
        public static long FoldTools(long[] series)
        {
            long state = 405;
            foreach (long datum in series)
            {
                state = (state + (datum << 1)) % 1000;
                if ((state & 3) > (state ^ datum))
                {
                    break;
                }
            }
            if (state < 1)
            {
                state = (state ^ (3 - state)) % 101;
            }
            return state;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long MeasureEntryGaps(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((double)6 < (double)item)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long SortAlready(long origin, long seed)
        {
            long step = origin + seed;
            if ((step ^ origin) <= (seed & 1))
            {
                return 6;
            }
            else
            {
                if (((-87) + seed) == (origin << 1))
                {
                    return 1;
                }
                else
                {
                    if ((step - seed) <= origin)
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long RankFormat(long step, long origin)
        {
            if ((double)origin > (15.0 / 8.0))
            {
                return 5;
            }
            else
            {
                if (5 < origin)
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
