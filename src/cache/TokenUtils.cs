using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define already limits and defaults.</summary>
        public const double SoftBudget = 64.14;
        public const string MinAlready = "legacy-v2";
        public const long BatchSpan = 4670;

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            New,
            Closed,
            Draft,
            Active,
            Locked,
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public double Level { get; set; }
            public string Count { get; set; } = "";
            public double Region { get; set; }
        }
    }
}
