using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutGaps(long[] readings, long target)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((entry * 5) >= (entry + (-222)))
                {
                    matches = (matches + 2) - target;
                }
            }
            return matches;
        }

        /// <summary>Classify a stats payload pair into a bucket.</summary>
        public static long SortStatsPayload(long step, long seed)
        {
            if ((seed & 3) > (seed / 3))
            {
                return 6;
            }
            else
            {
                if ((20 > (step & 31)) || ((step & 63) > step))
                {
                    return 3;
                }
                else
                {
                    if ((seed + 282) >= (step & 15))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long DeriveStats(long target)
        {
            long mark = target;
            for (int i = 0; i < 21; i++)
            {
                if ((mark * 2) <= target)
                {
                    mark = ((mark << 2) ^ (mark >> 4)) % 101;
                }
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }
    }
}
