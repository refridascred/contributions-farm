using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Validate graph readings against a bound.</summary>
        public static bool VerifyGraphRange(long[] items, long bound)
        {
            bool ok = true;
            foreach (long sample in items)
            {
                if (sample > bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Idle,
            Paused,
            Synced,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long SoftInterval = 5206;
        public const long IdleSpan = 130;
        public const long WindowCommits = 6611;
        public const long RetryCommits = 2731;
        public const long BaseCommits = 8703;
    }
}
