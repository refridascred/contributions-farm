using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const string IdleLayout = "stable";
        public const double SoftSpan = 47.14;
        public const long LimitInterval = 6637;
        public const double BaseLayout = 23.15;

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Synced,
            Closed,
            Locked,
            Active,
            New,
        }

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Ready,
            Done,
            Pending,
            Draft,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string LimitRatio = "cached-1";
        public const long MaxRatio = 1803;
        public const long StepTimeout = 4748;
        public const long CacheSchema = 4405;
        public const long MaxSchema = 9584;

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public long Label { get; set; }
            public long Flag { get; set; }
        }
    }
}
