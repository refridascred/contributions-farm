using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string SoftGithubfarm = "staging-1";
        public const long LimitBudget = 9911;
        public const long HardGithubfarm = 5483;
        public const double DefaultBudget = 5.59;

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public long Score { get; set; }
            public bool Owner { get; set; }
            public long Label { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Stale,
            Closed,
            Dropped,
            Draft,
        }
    }
}
