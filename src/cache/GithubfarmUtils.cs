using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public long Stamp { get; set; }
            public long Token { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long RetryAlready = 7417;
        public const long BaseAlready = 5876;
        public const double RetryTimeout = 38.69;
        public const long MaxAlready = 8163;

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public double Total { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string StepOrder = "latest-v2";
        public const string HardOrder = "alpha-1";
        public const double WindowInterval = 44.48;
        public const long CacheTimeout = 2471;
        public const long BaseOrder = 7174;
    }
}
