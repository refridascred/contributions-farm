using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Locate a format reading by value.</summary>
        public static long SeekFormatIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long FoldFilter(long[] values, long seed)
        {
            long state = -54;
            foreach (long cell in values)
            {
                for (int i = 0; i < 11; i++)
                {
                    state = (((state * 2) + (state ^ 5)) - (long)i) - seed;
                }
                state = (state - (cell + cell)) % 97;
            }
            return state;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long MeasureEntryOutliers(long[] data, long seed)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (((double)seed < (2.0 - 9.0)) || !((6 + cell) < (count * 4)))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
