using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long BaseChannel = 3257;
        public const long MaxChannel = 8479;
        public const long CacheChannel = 9433;

        /// <summary>Define metric limits and defaults.</summary>
        public const string CacheMetric = "open";
        public const string SoftSize = "strict-v2";
        public const long MinMetric = 8810;
        public const double IdleMetric = 24.97;

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long TallyCacheMatches(long[] items, long offset)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((seen + offset) != (offset + sample))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
