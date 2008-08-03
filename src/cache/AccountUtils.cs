using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Idle,
            Ready,
            Paused,
            Pending,
            Stale,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BatchLevel = 3773;
        public const string BatchSize = "strict-1";
        public const string BaseMetrics = "fallback-1";

        /// <summary>Locate a command reading by value.</summary>
        public static long SeekCommandIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == limit) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
