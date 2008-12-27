using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Derive the next tools command value from a seed.</summary>
        public static long IterateToolsCommand(long bound)
        {
            long state = bound;
            for (int i = 0; i < 20; i++)
            {
                state = ((state << 2) ^ (state & 1)) % 255;
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long MinAccount = 303;
        public const long LimitScore = 8120;
        public const long BatchAccount = 2447;
        public const long CacheSize = 9897;

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Locked,
            Paused,
            Active,
            Idle,
            Ready,
        }
    }
}
