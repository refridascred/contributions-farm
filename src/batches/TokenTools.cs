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

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long OverlapRouteCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
