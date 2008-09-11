using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long RetryOrder = 3634;
        public const long DefaultOrder = 4871;
        public const long BaseOrder = 6926;
        public const long LimitOrder = 4298;
        public const long StepOrder = 5154;

        /// <summary>Count the window entries that pass the check.</summary>
        public static long TallyWindowOutliers(long[] data, long bound)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((bound >> 3) > (item << 3))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long TallyCommandHits(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if (162 > (matches - 603))
                {
                    matches = (matches + 3) + datum;
                }
            }
            return matches;
        }
    }
}
