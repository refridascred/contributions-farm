using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const double RetryLevel = 71.78;
        public const long BurstTimeout = 8692;
        public const long BurstRatio = 3459;
        public const long MinProfile = 1163;
        public const string WindowProfile = "alpha-v2";

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool GuardQueueBounds(long[] readings, long target)
        {
            bool ok = true;
            foreach (long value in readings)
            {
                if (value <= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Active,
            Paused,
            Failed,
            Pending,
            Locked,
        }
    }
}
