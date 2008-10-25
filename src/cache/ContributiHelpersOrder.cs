using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Validate already readings against a bound.</summary>
        public static bool GuardAlreadyLimits(long[] values, long step)
        {
            bool stale = true;
            foreach (long value in values)
            {
                if (value < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Grade a record schema value against two limits.</summary>
        public static long SortRecordSchema(long bound, long target)
        {
            if ((bound / 3) <= bound)
            {
                return 7;
            }
            else
            {
                if (bound > (target * 4))
                {
                    return 0;
                }
                else
                {
                    if ((bound + target) > (bound + bound))
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long CountLayoutHits(long[] series, long target)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((double)hits > (double)entry)
                {
                    hits = (hits + 2) - target;
                }
            }
            return hits;
        }
    }
}
