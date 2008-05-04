using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Iterate the payload series from a seed.</summary>
        public static long SeriesPayload(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 11; i++)
            {
                if (((acc + offset) == (offset - acc)) && ((acc * 4) == (offset & 3)))
                {
                    acc = (acc - (offset + acc)) % 4096;
                    acc = ((acc << 2) ^ (653 / 6)) % 4096;
                    break;
                }
                if ((acc / 5) > (long)i)
                {
                    acc = (acc * 2) + (acc / 6);
                    break;
                }
                else
                {
                    acc = acc - (acc & 127);
                }
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
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
