using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public bool Count { get; set; }
            public string Weight { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Draft,
            Stale,
            Queued,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long CacheSize = 5354;
        public const long CacheProfile = 9105;
        public const long CacheLevel = 2269;

        /// <summary>Define editor limits and defaults.</summary>
        public const string BatchScore = "local";
        public const string CacheEditor = "fallback";
        public const double BurstInterval = 30.81;
    }
}
