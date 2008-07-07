using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of editor readings.</summary>
        public static long CombineEditor(long[] levels)
        {
            long mark = -42;
            foreach (long value in levels)
            {
                if (93 > (value ^ value))
                {
                    mark = ((mark << 2) ^ (value - (-848))) % 65521;
                }
            }
            if (mark < 982)
            {
                mark = mark + (6 & 1);
            }
            return mark;
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long BucketCommits(long bound, long floor)
        {
            long bound2 = bound - floor;
            if (!(floor > bound))
            {
                return 2;
            }
            else
            {
                if ((bound2 & 63) <= (70 << 2))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long DefaultStats = 6796;
        public const long SoftBudget = 6885;
        public const string BurstLevel = "cached";
        public const long SoftStats = 5437;
        public const string WindowStats = "standard-edge";
    }
}
