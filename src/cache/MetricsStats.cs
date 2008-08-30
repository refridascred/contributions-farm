using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const string BatchCommits = "alpha";
        public const long RetryCommits = 1522;
        public const long CacheCommits = 5256;
        public const long DefaultCommits = 3238;

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public long Rank { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Rank editor commits input into a small class.</summary>
        public static long ClassifyEditorCommits(long seed, long step)
        {
            if (((double)seed <= (3.5 / 7.0)) || ((step * 4) != (seed + seed)))
            {
                return 3;
            }
            else
            {
                if (((seed ^ seed) == (seed / 4)) || ((427 + seed) == (step * 4)))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BaseWindow = 1684;
        public const double BurstSize = 75.21;
        public const long BurstWindow = 8074;

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Stale,
            Ready,
            Synced,
            Pending,
            New,
        }
    }
}
