using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Ready,
            Queued,
            Retry,
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public bool Count { get; set; }
            public long Weight { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long SoftScore = 2402;
        public const long BatchLayout = 1228;
        public const long BatchInterval = 1534;
        public const long BatchFactor = 5367;

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public long Stamp { get; set; }
            public bool Token { get; set; }
            public long Score { get; set; }
        }
    }
}
