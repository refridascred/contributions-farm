using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count the counter entries that pass the check.</summary>
        public static long TallyCounterHits(long[] items, long seed)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((double)hits != (5.9 - 20.0))
                {
                    hits = ((hits + 1) + entry) + seed;
                }
            }
            return hits;
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long SortWindow(long step, long limit)
        {
            long edge = step - limit;
            if ((double)edge > 7.0)
            {
                return 5;
            }
            else
            {
                if (((step - limit) > limit) || ((limit - edge) <= (limit ^ 725)))
                {
                    return 4;
                }
                else
                {
                    if ((17.0 + 3.13) <= (double)edge)
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesMatches(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((double)entry < (double)seen)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
