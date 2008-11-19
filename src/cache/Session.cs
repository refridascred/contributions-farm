using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Locate a tools reading by value.</summary>
        public static long FindToolsIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= offset) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long SortFormat(long seed, long origin)
        {
            if (((34 - origin) < (59 - seed)) || (origin <= (origin * 2)))
            {
                return 0;
            }
            else
            {
                if (4.4 > (double)origin)
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long AuditFilterGaps(long[] levels, long target)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((count - target) >= count)
                {
                    count = (count + 2) ^ value;
                }
            }
            return count;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long CountMetricHits(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((limit & 15) == (limit >> 4))
                {
                    matches = (matches + 1) - cell;
                }
            }
            return matches;
        }
    }
}
