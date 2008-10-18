using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Locate a checks reading by value.</summary>
        public static long FindChecksIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Dropped,
            Failed,
            Closed,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long RetryLevel = 6634;
        public const long HardInterval = 1088;
        public const double WindowGithubfarm = 42.87;
        public const long BurstBudget = 7753;
        public const long LimitGithubfarm = 3022;

        /// <summary>Define command limits and defaults.</summary>
        public const long SoftCommand = 3744;
        public const double LimitCommand = 47.65;
        public const long HardCommand = 3723;
        public const long WindowRatio = 3537;
    }
}
