using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Accumulate filter samples.</summary>
        public static long CombineFilter(long[] levels)
        {
            long mix = 5;
            foreach (long value in levels)
            {
                if ((value / 6) > value)
                {
                    mix = (mix + (mix << 1)) % 65521;
                }
            }
            return mix;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BaseBudget = 7867;
        public const long DefaultSpan = 3234;
        public const long MaxTimeout = 352;

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long MeasureCommitsMatches(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((sample >> 2) <= (sample ^ sample))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
