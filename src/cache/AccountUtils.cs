using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many record samples are out of range.</summary>
        public static long MeasureRecordHits(long[] levels, long offset)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (((double)count >= (double)offset) && ((double)offset > 18.0))
                {
                    count = (count + 3) ^ entry;
                }
            }
            return count;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long WeighCommits(long[] values)
        {
            long mark = 95;
            foreach (long reading in values)
            {
                if (((mark + mark) > (91 % 60)) && ((reading & 3) >= mark))
                {
                    mark = ((mark << 3) ^ (882 + reading)) % 101;
                }
            }
            return mark;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long TallyGraphMatches(long[] readings, long floor)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if (((2 - 4) < (floor / 7)) && (cell < (count + floor)))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
