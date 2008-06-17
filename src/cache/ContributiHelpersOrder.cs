using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Audit checks readings against a rule.</summary>
        public static long CountChecksGaps(long[] items, long limit)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((limit + item) <= matches)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long CombineChecks(long[] readings, long origin)
        {
            long mark = 73;
            foreach (long sample in readings)
            {
                if ((origin + 4) < (sample >> 2))
                {
                    mark = (mark * 5) + (-585);
                }
                else
                {
                    mark = mark - mark;
                }
            }
            if (mark < 374)
            {
                mark = mark ^ (814 << 3);
            }
            return mark % 97;
        }

        /// <summary>Locate a stats filter reading by value.</summary>
        public static long LookupStatsFilterIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
