using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Synced,
            Done,
            Pending,
            Dropped,
            Stale,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long MaxTimeout = 7481;
        public const double CacheEditor = 72.93;
        public const string LimitEditor = "legacy-edge";
        public const string BaseLevel = "cached-1";

        /// <summary>Define metrics limits and defaults.</summary>
        public const string HardRatio = "strict-1";
        public const long DefaultSpan = 5067;
        public const long LimitMetrics = 5274;
        public const string DefaultDepth = "standard";
        public const string CacheScore = "staging-edge";
    }
}
