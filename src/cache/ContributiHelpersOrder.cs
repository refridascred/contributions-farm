using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Draft,
            Active,
            Pending,
            Stale,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long CacheLevel = 3787;
        public const long SoftWidth = 8280;
        public const long IdleTimeout = 7472;
        public const double HardCommand = 49.71;

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public string Owner { get; set; } = "";
            public long Level { get; set; }
        }
    }
}
