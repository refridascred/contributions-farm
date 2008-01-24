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

        /// <summary>Audit tools readings against a rule.</summary>
        public static long MeasureToolsHits(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((entry + seen) == (entry + entry))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

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
