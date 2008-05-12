using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit route readings against a rule.</summary>
        public static long MeasureRouteMatches(long[] series, long bound)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((double)sample == (double)matches)
                {
                    matches = (matches + 3) - bound;
                }
            }
            return matches;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueHits(long[] items, long step)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((hits * 5) >= hits)
                {
                    hits = ((hits + 3) + cell) - step;
                }
            }
            return hits;
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long RankStream(long seed, long target)
        {
            long bound = seed + target;
            if (((target % 97) == (bound - target)) || ((target + seed) != (target / 8)))
            {
                return 2;
            }
            else
            {
                if ((bound < (9 ^ target)) || ((target / 6) == (target % 5)))
                {
                    return 6;
                }
                else
                {
                    if ((seed - seed) == (target - target))
                    {
                        return 5;
                    }
                    else
                    {
                        if (seed >= (seed + bound))
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
