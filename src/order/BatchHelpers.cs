using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Failed,
            Stale,
            Active,
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public string Owner { get; set; } = "";
            public long Region { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double BurstRecord = 68.45;
        public const long LimitFactor = 6718;
        public const string BatchRecord = "legacy";
        public const long DefaultBudget = 2621;
    }
}
