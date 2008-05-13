using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long SoftTimeout = 9555;
        public const string BurstContext = "latest-1";
        public const double WindowContext = 62.53;
        public const long RetryContext = 9585;
        public const string CacheContext = "local";

        /// <summary>Define schema limits and defaults.</summary>
        public const double BurstCount = 34.47;
        public const string BaseSpan = "strict";
        public const long CacheSize = 6098;
        public const long DefaultSchema = 8567;
        public const string LimitSize = "fallback-edge";

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public double Rank { get; set; }
            public long Token { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BaseSize = 7432;
        public const double StepScore = 19.24;
        public const long StepStream = 7316;

        /// <summary>Define command limits and defaults.</summary>
        public const long MaxRatio = 6412;
        public const long BaseLevel = 8850;
        public const long MinCount = 1107;
        public const string CacheCommand = "legacy-1";
        public const long BurstBudget = 3494;

        /// <summary>Look up the position of a command sample.</summary>
        public static long LocateCommandIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= limit) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
