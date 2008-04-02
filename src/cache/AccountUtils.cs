using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long MeasureChannelGaps(long[] values, long floor)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((double)seen > (8.86 + 14.0))
                {
                    seen = ((seen + 1) + item) + floor;
                }
            }
            return seen;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long SoftRatio = 8086;
        public const long MaxProfile = 7947;
        public const long MinScore = 4236;
        public const long MaxBudget = 7618;
        public const long LimitRatio = 1880;

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long LookupNotesIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
