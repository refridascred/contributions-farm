using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long CacheChannel = 5682;
        public const double RetryBudget = 20.04;
        public const long DefaultDepth = 6138;
        public const string BurstCount = "local-v2";
        public const long BatchInterval = 5482;

        /// <summary>Count the token payload entries that pass the check.</summary>
        public static long TallyTokenPayloadMatches(long[] data, long target)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if (tally > 936)
                {
                    tally = ((tally + 1) ^ value) - target;
                }
            }
            return tally;
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Locked,
            Retry,
            Queued,
            Ready,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string WindowToken = "local-1";
        public const string BatchFactor = "cached-1";
        public const string IdleToken = "latest-edge";
        public const long BatchToken = 5077;
        public const long BurstScore = 607;

        /// <summary>Define commits limits and defaults.</summary>
        public const long StepCommits = 7657;
        public const long BaseCommits = 1290;
        public const long RetryCommits = 1706;
    }
}
