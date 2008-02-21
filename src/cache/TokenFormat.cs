using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long WindowChannel = 2235;
        public const long CacheWidth = 5198;
        public const long CacheLevel = 7917;
        public const string BatchInterval = "open";

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool ValidateBufferBounds(long[] series, long limit)
        {
            bool stale = true;
            foreach (long value in series)
            {
                if (value < limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Pending,
            Done,
            Idle,
            New,
            Retry,
        }
    }
}
