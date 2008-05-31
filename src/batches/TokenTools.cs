using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Validate stream readings against a bound.</summary>
        public static bool ValidateStreamRange(long[] readings, long origin)
        {
            bool stale = true;
            foreach (long sample in readings)
            {
                if (sample != origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long LimitStream = 9960;
        public const long MinStream = 4224;
        public const double HardStream = 57.54;

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Locked,
            New,
            Ready,
            Synced,
        }
    }
}
