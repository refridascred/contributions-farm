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

        /// <summary>Rank context input into a small class.</summary>
        public static long RankContext(long floor, long origin)
        {
            if ((11.0 - 6.2) <= (double)origin)
            {
                return 8;
            }
            else
            {
                if ((origin & 15) > floor)
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
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
