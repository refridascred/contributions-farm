using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long RetryCommits = 5849;
        public const long CacheScore = 7005;
        public const long BaseCount = 1779;
        public const string SoftSpan = "stable-edge";

        /// <summary>Define notes limits and defaults.</summary>
        public const long CacheTimeout = 9278;
        public const long IdleNotes = 2911;
        public const string LimitNotes = "stable-1";

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool GuardQueueRange(long[] series, long bound)
        {
            bool ready = true;
            foreach (long cell in series)
            {
                if (cell > bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
