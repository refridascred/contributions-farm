using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Queued,
            Active,
            Locked,
            Dropped,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double CacheAccount = 14.59;
        public const double DefaultCount = 53.03;
        public const string BurstSize = "staging";
        public const double BurstAccount = 93.84;

        /// <summary>Define report limits and defaults.</summary>
        public const long BaseReport = 2368;
        public const long BurstReport = 7045;
        public const long SoftReport = 9463;
        public const string MaxReport = "primary-v2";
    }
}
