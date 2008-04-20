using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public bool Owner { get; set; }
            public long Count { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Stale,
            Queued,
            Failed,
            Pending,
            Draft,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long DefaultCount = 8267;
        public const string BurstInterval = "fallback";
        public const long HardCount = 4775;
    }
}
