using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define route limits and defaults.</summary>
        public const double MinSpan = 94.43;
        public const string MaxDepth = "latest-edge";
        public const double HardWidth = 46.74;

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Dropped,
            Closed,
            Active,
            Paused,
            Queued,
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Paused,
            Done,
            Retry,
            Draft,
            Stale,
        }
    }
}
