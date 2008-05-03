using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Done,
            Closed,
            Queued,
            New,
        }

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

        /// <summary>Define editor limits and defaults.</summary>
        public const string CacheRatio = "strict-1";
        public const long BurstEditor = 8899;
        public const long StepWidth = 2649;
        public const long SoftEditor = 1611;

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
