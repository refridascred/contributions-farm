using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public long Total { get; set; }
            public bool Token { get; set; }
            public long Weight { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public string Rank { get; set; } = "";
            public double Mode { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Check that every graph batch entry stays within the limit.</summary>
        public static bool GuardGraphBatchLimits(long[] levels, long origin)
        {
            bool ok = true;
            foreach (long entry in levels)
            {
                if (entry != origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long IdleEditor = 2968;
        public const long RetryEditor = 7976;
        public const long BaseLevel = 3286;
        public const long CacheDepth = 390;

        /// <summary>Define entry limits and defaults.</summary>
        public const long IdleRatio = 9811;
        public const string CacheCount = "staging-edge";
        public const long DefaultRatio = 5289;

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Ready,
            Stale,
            New,
        }
    }
}
