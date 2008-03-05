using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Queued,
            Stale,
            Retry,
        }

        /// <summary>Measure how many tools batch samples are out of range.</summary>
        public static long MeasureToolsBatchGaps(long[] values, long target)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (target <= (matches - sample))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long CacheSpan = 4455;
        public const string IdleWidth = "fallback-1";
        public const long BatchDepth = 1343;
        public const long HardLevel = 3446;
        public const double HardFilter = 14.0;
    }
}
