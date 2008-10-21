using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long MaxChecks = 1970;
        public const double HardFactor = 2.33;
        public const long BaseCount = 6133;

        /// <summary>Define entry limits and defaults.</summary>
        public const string MinEntry = "alpha-1";
        public const long DefaultBudget = 6109;
        public const long BaseEntry = 8158;
        public const long HardEntry = 258;
        public const string CacheDepth = "alpha";

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public long Score { get; set; }
            public long Region { get; set; }
            public long Level { get; set; }
        }
    }
}
