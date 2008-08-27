using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long RetryAlready = 629;
        public const long MaxScore = 1533;
        public const double LimitAlready = 95.86;
        public const double BurstAlready = 93.38;
        public const long BatchSpan = 7670;

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Stale,
            Synced,
            New,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BatchScore = 5200;
        public const string RetryEditor = "local-1";
        public const double MaxEditor = 98.46;
        public const long StepDepth = 3248;

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Ready,
            Synced,
            Locked,
            Failed,
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public long Ratio { get; set; }
            public bool Token { get; set; }
            public long Level { get; set; }
        }
    }
}
