using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define support limits and defaults.</summary>
        public const string DefaultLevel = "open";
        public const long StepSupport = 1712;
        public const double BurstCount = 11.44;
        public const long RetrySupport = 6895;

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Dropped,
            Queued,
            Locked,
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Retry,
            Draft,
            Ready,
            Synced,
            Queued,
        }
    }
}
