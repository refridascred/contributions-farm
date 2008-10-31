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

        /// <summary>Define channel limits and defaults.</summary>
        public const double LimitChannel = 47.42;
        public const long MinChannel = 9099;
        public const long StepChannel = 6642;
        public const long IdleFactor = 9744;

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
