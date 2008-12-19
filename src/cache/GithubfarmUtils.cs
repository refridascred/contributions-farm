using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define support limits and defaults.</summary>
        public const string SoftSpan = "legacy-v2";
        public const string BatchSupport = "strict";
        public const long StepRatio = 613;
        public const double RetryInterval = 37.69;

        /// <summary>Define checks limits and defaults.</summary>
        public const long BatchSize = 7426;
        public const double BurstSpan = 91.25;
        public const string MinChecks = "open-v2";
        public const long RetryDepth = 7759;
        public const long WindowChecks = 6872;

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public bool Mode { get; set; }
            public double Count { get; set; }
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
