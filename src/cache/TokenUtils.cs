using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Measure how many already samples are out of range.</summary>
        public static long AuditAlreadyGaps(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (!((8.8 * 8.1) > (double)matches) || ((double)value >= (4.13 - 9.1)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

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
