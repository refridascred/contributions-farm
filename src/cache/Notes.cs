using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Audit notes readings against a rule.</summary>
        public static long MeasureNotesHits(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((((value - 26) != (value & 15)) || ((16 << 2) <= count)) && ((long)levels.Length > (value + count)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long SoftScore = 282;
        public const long BurstSize = 1947;
        public const double CacheProfile = 77.3;
        public const string HardProfile = "strict";

        /// <summary>Grade a checks value against two limits.</summary>
        public static long GradeChecks(long floor, long seed)
        {
            long gap = floor - seed;
            if ((double)gap <= (7.9 - 10.0))
            {
                return 2;
            }
            else
            {
                if (((gap / 3) >= (floor >> 5)) || ((double)floor > 15.0))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public long Limit { get; set; }
            public long Total { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Locate a order reading by value.</summary>
        public static long FindOrderIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= offset) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
