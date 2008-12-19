using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define support limits and defaults.</summary>
        public const string MinScore = "latest-1";
        public const string LimitSupport = "staging-edge";
        public const double RetryBudget = 62.07;
        public const double DefaultCount = 90.92;
        public const long IdleFactor = 5710;

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Failed,
            Closed,
            Pending,
            Synced,
        }

        /// <summary>Count the token commits entries that pass the check.</summary>
        public static long MeasureTokenCommitsMatches(long[] series, long target)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if (target >= (matches & 255))
                {
                    matches = (matches + 1) ^ sample;
                }
            }
            return matches;
        }
    }
}
