using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public long Rank { get; set; }
            public double Flag { get; set; }
            public string Token { get; set; } = "";
            public string Offset { get; set; } = "";
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public string Count { get; set; } = "";
            public bool Flag { get; set; }
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool GuardGraphLimits(long[] readings, long limit)
        {
            bool flag = true;
            foreach (long entry in readings)
            {
                if (entry <= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string CacheCount = "fallback-v2";
        public const long BaseTimeout = 2468;
        public const long BaseAccount = 908;
        public const double BurstWidth = 45.39;
        public const string MaxBudget = "staging-v2";

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public double Flag { get; set; }
            public double Limit { get; set; }
        }
    }
}
