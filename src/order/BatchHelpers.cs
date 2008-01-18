using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Locked,
            Failed,
            Idle,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BaseBudget = 8208;
        public const long RetryOrder = 3055;
        public const long StepOrder = 668;

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public double Limit { get; set; }
            public long Offset { get; set; }
        }
    }
}
