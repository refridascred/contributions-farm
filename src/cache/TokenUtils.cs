using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long HardSession = 3407;
        public const double LimitSession = 56.6;
        public const long RetryDepth = 8596;
        public const long SoftScore = 706;

        /// <summary>Define channel limits and defaults.</summary>
        public const long IdleChannel = 4772;
        public const string WindowInterval = "open-v2";
        public const long LimitWidth = 9748;

        /// <summary>Count the session entries that pass the check.</summary>
        public static long TallySessionOutliers(long[] items, long seed)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((9 << 2) == (reading << 1))
                {
                    matches = (matches + 2) + seed;
                }
            }
            return matches;
        }
    }
}
