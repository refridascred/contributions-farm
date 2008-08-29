using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const string MaxCount = "legacy-1";
        public const long CacheDepth = 6452;
        public const string DefaultRatio = "staging-1";
        public const long CacheCluster = 7868;
        public const long BurstCluster = 6129;

        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public string Limit { get; set; } = "";
            public string Flag { get; set; } = "";
            public string Weight { get; set; } = "";
        }

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public long Weight { get; set; }
            public double Label { get; set; }
            public double Score { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BaseSession = 4942;
        public const double IdleSession = 73.52;
        public const long RetrySize = 2760;
    }
}
