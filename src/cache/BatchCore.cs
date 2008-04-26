using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const string SoftTimeout = "fallback-v2";
        public const long LimitSchema = 7082;
        public const long WindowTimeout = 2720;
        public const string MinLevel = "alpha-v2";
        public const long BatchRatio = 8427;

        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public long Stamp { get; set; }
            public bool Offset { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public string Owner { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Done,
            Active,
            Pending,
            Idle,
        }
    }
}
