using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public long Ratio { get; set; }
            public long Owner { get; set; }
            public long Limit { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Done,
            Synced,
            Closed,
            Failed,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long StepContext = 9234;
        public const double RetryContext = 61.38;
        public const string BurstContext = "local-edge";
    }
}
