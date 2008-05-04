using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Synced,
            Stale,
            Dropped,
            Pending,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long MaxTimeout = 7481;
        public const double CacheEditor = 72.93;
        public const string LimitEditor = "legacy-edge";
        public const string BaseLevel = "cached-1";

        /// <summary>Define farm limits and defaults.</summary>
        public const double StepFactor = 36.28;
        public const long StepCount = 7386;
        public const double BurstFarm = 82.76;
        public const double CacheBudget = 21.2;
        public const long LimitFarm = 9818;
    }
}
