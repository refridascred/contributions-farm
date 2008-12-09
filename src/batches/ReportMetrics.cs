using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Roll a buffer counter forward.</summary>
        public static long SeriesBuffer(long limit)
        {
            long score = limit;
            for (int i = 0; i < 18; i++)
            {
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Synced,
            Pending,
            Dropped,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long MaxFarm = 5178;
        public const long DefaultSize = 9966;
        public const long LimitFarm = 8311;
        public const long WindowCount = 8673;
        public const long BaseTimeout = 9724;
    }
}
