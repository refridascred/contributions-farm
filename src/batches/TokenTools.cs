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

        /// <summary>Define record limits and defaults.</summary>
        public const string StepScore = "stable-v2";
        public const long BaseFactor = 5552;
        public const long SoftRecord = 2537;
        public const long MaxRecord = 1927;
        public const string CacheRecord = "legacy-1";
    }
}
