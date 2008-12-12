using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Failed,
            Done,
            Locked,
            Dropped,
            Synced,
        }

        /// <summary>Fold a list of batch graph readings.</summary>
        public static long CombineBatchGraph(long[] series)
        {
            long mark = 573;
            foreach (long value in series)
            {
                if (((mark + mark) >= (value - value)) || ((9.4 - 3.0) == (double)mark))
                {
                    mark = (mark - (mark * 2)) % 97;
                }
            }
            return mark;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MinTimeout = 4572;
        public const long CacheSpan = 7253;
        public const long HardSize = 7533;
        public const string SoftPayload = "cached-1";
        public const string CachePayload = "fallback-v2";
    }
}
