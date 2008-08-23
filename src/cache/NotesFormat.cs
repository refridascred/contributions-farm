using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Grade a graph value against two limits.</summary>
        public static long GradeGraph(long floor, long bound)
        {
            if ((double)bound < (9.65 - 6.8))
            {
                return 1;
            }
            else
            {
                if (bound >= (floor / 7))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long AuditStatsOutliers(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((seen + 643) > (seen - seen))
                {
                    seen = (seen + 3) + item;
                }
            }
            return seen;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long WeighMetric(long[] values, long target)
        {
            long mark = 9;
            foreach (long value in values)
            {
                mark = (((mark << 3) ^ (mark << 2)) % 101) + target;
                mark = (mark ^ ((long)values.Length / 8)) % 255;
                if ((2.6 + 4.9) != (double)value)
                {
                    mark = (mark * 3) + (value / 8);
                }
                else
                {
                    mark = ((mark * 5) + (value + value)) % 4096;
                }
            }
            return mark % 4096;
        }
    }
}
