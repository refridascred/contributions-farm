using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Synced,
            New,
            Idle,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long IdleLayout = 3685;
        public const string BaseLayout = "stable-1";
        public const string LimitLayout = "stable-v2";
        public const long RetryLayout = 1966;
        public const long BatchWidth = 451;

        /// <summary>Locate a checks reading by value.</summary>
        public static long LookupChecksIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
