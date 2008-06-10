using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Dropped,
            Pending,
            Active,
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Active,
            Locked,
            Stale,
            Closed,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long CacheWindow = 1987;
        public const long MinWindow = 2204;
        public const long BaseTimeout = 1689;

        /// <summary>Define format limits and defaults.</summary>
        public const double LimitTimeout = 11.14;
        public const long CacheFormat = 8183;
        public const long BatchRatio = 557;
        public const long RetryFormat = 3272;

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public long Stamp { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Compare every pair of window readings.</summary>
        public static long OverlapWindowCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
