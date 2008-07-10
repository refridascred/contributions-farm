using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            New,
            Closed,
            Paused,
            Queued,
            Failed,
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Failed,
            Stale,
            Active,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double HardCount = 94.5;
        public const double BatchWidth = 93.76;
        public const long CacheSchema = 6801;
        public const long RetryInterval = 5781;
    }
}
