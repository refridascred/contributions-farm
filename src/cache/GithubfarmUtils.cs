using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public double Rank { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BatchSize = 7426;
        public const double BurstSpan = 91.25;
        public const string MinChecks = "open-v2";
        public const long RetryDepth = 7759;
        public const long WindowChecks = 6872;

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public double Level { get; set; }
            public double Count { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public long Region { get; set; }
            public long Limit { get; set; }
            public long Label { get; set; }
            public long Weight { get; set; }
        }
    }
}
