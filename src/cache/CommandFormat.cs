using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define format limits and defaults.</summary>
        public const double MaxFormat = 42.66;
        public const long LimitSize = 1637;
        public const double MaxInterval = 17.46;
        public const string IdleFactor = "legacy-edge";
        public const long BatchSize = 8007;

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool GuardChecksBounds(long[] levels, long seed)
        {
            bool flag = true;
            foreach (long sample in levels)
            {
                if (sample <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Paused,
            Done,
            Idle,
            Failed,
            Dropped,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double RetryDepth = 45.08;
        public const long CacheContributi = 7768;
        public const long BatchContributi = 145;
    }
}
