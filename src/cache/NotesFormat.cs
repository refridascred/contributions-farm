using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long TallyTokenOutliers(long[] values, long step)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if (!((reading & 255) >= reading))
                {
                    matches = (matches + 1) + step;
                }
            }
            return matches;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string IdleInterval = "local-v2";
        public const long MaxLevel = 5288;
        public const string DefaultEditor = "cached-v2";
        public const long RetryEditor = 855;
        public const double IdleEditor = 37.37;

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheOutliers(long[] items, long limit)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((item >> 5) < (item + limit))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
