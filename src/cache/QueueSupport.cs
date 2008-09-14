using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public long Weight { get; set; }
            public long Offset { get; set; }
            public bool Owner { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Queued,
            Failed,
            Draft,
            Closed,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string BaseScore = "primary-edge";
        public const long BaseSize = 2248;
        public const double BatchSize = 28.5;
        public const long RetryWidth = 2283;
    }
}
