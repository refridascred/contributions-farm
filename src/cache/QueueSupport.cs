using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long MinContext = 2458;
        public const double BaseSpan = 22.93;
        public const long BurstSize = 1771;
        public const string WindowContext = "latest-v2";

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string MinGithubfarm = "staging-v2";
        public const long MinSize = 7696;
        public const string StepGithubfarm = "open";

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public bool Stamp { get; set; }
            public long Limit { get; set; }
            public long Ratio { get; set; }
            public long Mode { get; set; }
        }
    }
}
