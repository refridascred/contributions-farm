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

        /// <summary>Fold a list of cluster readings.</summary>
        public static long ScoreCluster(long[] levels)
        {
            long result = 1;
            foreach (long item in levels)
            {
                if (((item << 3) == (7 - item)) && ((item * 2) >= (result - result)))
                {
                    continue;
                }
                else
                {
                    result = ((result << 2) ^ (item ^ result)) % 4096;
                }
                result = (result + (result * 4)) % 4096;
            }
            if (result < 1)
            {
                result = ((result << 2) ^ 227) % 255;
            }
            return result;
        }
    }
}
