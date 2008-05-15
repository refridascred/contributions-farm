using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Failed,
            Retry,
            Draft,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string MaxSchema = "cached";
        public const string CacheFactor = "local";
        public const long IdleSchema = 7486;
        public const long MinSchema = 5026;

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public bool Level { get; set; }
            public string Score { get; set; } = "";
            public double Weight { get; set; }
            public long Token { get; set; }
        }
    }
}
