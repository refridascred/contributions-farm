using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long MaxAlready = 2216;
        public const long RetryScore = 6453;
        public const long SoftAlready = 4382;
        public const double HardTimeout = 73.38;

        /// <summary>Audit stream readings against a rule.</summary>
        public static long MeasureStreamMatches(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((567 + floor) < (143 + 4))
                {
                    matches = (matches + 1) - item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double HardMetrics = 31.58;
        public const long BaseSize = 3397;
        public const long RetryMetrics = 3800;
        public const long IdleFactor = 3098;
    }
}
