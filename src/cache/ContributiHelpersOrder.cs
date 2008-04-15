using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextOutliers(long[] series, long offset)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if (offset >= (reading & 7))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long WeighCounter(long[] readings)
        {
            long acc = 5;
            foreach (long item in readings)
            {
                acc = ((acc << 3) ^ item) % 101;
                acc = (acc * 5) + (acc >> 2);
            }
            if (acc < 2)
            {
                acc = ((acc * 3) + acc) % 97;
            }
            return acc % 4096;
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long SortBatch(long bound, long limit)
        {
            if ((double)bound < (17.0 + 1.5))
            {
                return 3;
            }
            else
            {
                if (!((double)limit == (5.0 + 10.0)))
                {
                    return 2;
                }
                else
                {
                    if (((bound % 16) == (limit ^ bound)) && ((622 & 255) <= bound))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
