using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public long Flag { get; set; }
            public string Total { get; set; } = "";
            public long Region { get; set; }
            public double Size { get; set; }
        }

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
