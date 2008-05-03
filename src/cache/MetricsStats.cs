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

        /// <summary>Count account cache pairs that satisfy a relation.</summary>
        public static long MatchAccountCacheCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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
