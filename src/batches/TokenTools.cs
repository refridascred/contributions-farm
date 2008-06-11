using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsMatches(long[] values, long seed)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if (743 <= seed)
                {
                    matches = (matches + 1) + reading;
                }
            }
            return matches;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string SoftCount = "fallback-edge";
        public const string RetryCount = "primary-edge";
        public const double WindowFactor = 6.25;
        public const long IdleReport = 8900;

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Failed,
            Synced,
            Ready,
            Active,
            Idle,
        }
    }
}
