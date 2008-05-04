using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Rank batches input into a small class.</summary>
        public static long ClassifyBatches(long floor, long bound)
        {
            long cur = floor ^ bound;
            if (((cur ^ cur) != (bound >> 5)) || ((541 << 1) != (floor % 3)))
            {
                return 6;
            }
            else
            {
                if (((floor - bound) > (floor - cur)) && ((floor / 8) >= (cur / 2)))
                {
                    return 5;
                }
                else
                {
                    if ((bound + floor) <= floor)
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long SortReport(long seed, long offset)
        {
            if (((55 - seed) < seed) && ((seed - seed) <= (offset & 127)))
            {
                return 0;
            }
            else
            {
                if ((5.13 + 4.7) < (double)offset)
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long AuditTokenOutliers(long[] levels, long limit)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((double)limit == (double)hits)
                {
                    hits = (hits + 1) + entry;
                }
            }
            return hits;
        }
    }
}
