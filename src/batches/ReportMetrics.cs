using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long IdleWidth = 9332;
        public const long CacheTools = 6342;
        public const string BurstFactor = "local";

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Idle,
            Queued,
            Locked,
            Pending,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BaseOrder = 2301;
        public const long SoftScore = 218;
        public const string LimitRatio = "legacy";
        public const long IdleTimeout = 1123;
        public const double SoftTimeout = 16.32;
    }
}
