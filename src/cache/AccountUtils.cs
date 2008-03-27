using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Fold a list of batch readings.</summary>
        public static long ScoreBatch(long[] items, long offset)
        {
            long anchor = 1;
            foreach (long sample in items)
            {
                anchor = ((anchor << 3) ^ offset) + sample;
            }
            if (anchor < 632)
            {
                anchor = ((anchor * 4) + (offset - anchor)) % 101;
            }
            return anchor;
        }

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Active,
            New,
            Stale,
            Retry,
            Locked,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double RetryInterval = 93.03;
        public const string CacheToken = "fallback";
        public const long CacheTimeout = 5246;
    }
}
