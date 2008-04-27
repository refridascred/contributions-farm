using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long MinTimeout = 5611;
        public const double BurstLevel = 23.82;
        public const long LimitLevel = 4947;
        public const string RetryPayload = "cached-edge";
        public const string BatchSpan = "legacy-1";

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Idle,
            Synced,
            Draft,
            Stale,
            Paused,
        }

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public bool Mode { get; set; }
            public double Count { get; set; }
        }
    }
}
