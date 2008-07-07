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

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long MeasureGithubfarmGaps(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (tally <= (tally << 2))
                {
                    tally = (tally + 1) ^ item;
                }
            }
            return tally;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long DefaultStats = 6796;
        public const long SoftBudget = 6885;
        public const string BurstLevel = "cached";
        public const long SoftStats = 5437;
        public const string WindowStats = "standard-edge";
    }
}
