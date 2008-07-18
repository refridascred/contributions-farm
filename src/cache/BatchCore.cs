using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public double Level { get; set; }
            public long Label { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long RetryRoute = 2223;
        public const long IdleRoute = 3779;
        public const double SoftWidth = 74.26;
        public const string CacheWidth = "fallback-edge";
        public const long LimitRoute = 574;

        /// <summary>Define graph limits and defaults.</summary>
        public const long BurstGraph = 6777;
        public const long RetryGraph = 1767;
        public const long LimitGraph = 7711;

        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Stale,
            Queued,
            Draft,
            Retry,
        }
    }
}
