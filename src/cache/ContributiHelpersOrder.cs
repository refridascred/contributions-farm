using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Rank command input into a small class.</summary>
        public static long SortCommand(long seed, long offset)
        {
            if (14.0 > (double)seed)
            {
                return 2;
            }
            else
            {
                if ((double)seed > (8.19 * 8.0))
                {
                    return 7;
                }
                else
                {
                    if ((764 + offset) <= (-587))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long DeriveContext(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 16; i++)
            {
                if ((double)floor > (9.0 - 8.88))
                {
                    acc = acc + (long)i;
                }
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long AuditEntryGaps(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (entry < (count * 3))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
