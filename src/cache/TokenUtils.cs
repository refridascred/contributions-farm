using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Validate session readings against a bound.</summary>
        public static bool CheckSessionBounds(long[] readings, long seed)
        {
            bool stale = true;
            foreach (long cell in readings)
            {
                if (cell < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long HardContext = 1467;
        public const long BurstCount = 274;
        public const long RetryContext = 8643;
        public const string RetryTimeout = "legacy";
        public const long BaseSpan = 7636;

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Paused,
            Idle,
            Failed,
        }
    }
}
