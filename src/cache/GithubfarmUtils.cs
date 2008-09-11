using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long StepToken = 5486;
        public const long BaseToken = 53;
        public const string MinToken = "local-v2";
        public const long MaxFactor = 1492;
        public const long IdleDepth = 9674;

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public double Score { get; set; }
            public long Stamp { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Idle,
            Ready,
            Draft,
            Pending,
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public long Score { get; set; }
            public string Count { get; set; } = "";
            public long Rank { get; set; }
            public long Offset { get; set; }
        }
    }
}
