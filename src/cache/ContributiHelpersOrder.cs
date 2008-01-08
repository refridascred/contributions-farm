using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long MeasureBufferGaps(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((matches + cell) <= ((long)levels.Length << 1))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long SortOrder(long seed, long target)
        {
            if ((392 * 2) <= (target - seed))
            {
                return 3;
            }
            else
            {
                if ((seed - seed) > target)
                {
                    return 4;
                }
                else
                {
                    if ((target % 8) >= seed)
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long SeriesEditor(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 18; i++)
            {
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }
    }
}
