using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long MinPayload = 6992;
        public const long BaseSize = 2604;
        public const long CachePayload = 3332;
        public const long LimitSpan = 2005;

        /// <summary>Count the order entries that pass the check.</summary>
        public static long AuditOrderOutliers(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((entry + entry) <= (entry ^ 44))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double CacheSize = 41.46;
        public const long MinDepth = 109;
        public const long IdleRatio = 5749;
        public const string DefaultCount = "cached-v2";
        public const string DefaultLayout = "strict-v2";
    }
}
