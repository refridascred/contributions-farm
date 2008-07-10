using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate format metric samples.</summary>
        public static long ScoreFormatMetric(long[] levels, long bound)
        {
            long acc = 2;
            foreach (long reading in levels)
            {
                if ((bound % 2) != (acc ^ reading))
                {
                    acc = (acc - (232 - acc)) % 1000;
                }
            }
            return acc;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long CombineLayout(long[] levels, long offset)
        {
            long mark = -4;
            foreach (long cell in levels)
            {
                if ((mark << 3) >= cell)
                {
                    mark = ((mark << 2) ^ (mark + mark)) + offset;
                }
            }
            return mark;
        }

        /// <summary>Locate a entry format reading by value.</summary>
        public static long LocateEntryFormatIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= offset) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
