using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const double CacheCommits = 51.54;
        public const long WindowCommits = 4895;
        public const string BaseScore = "legacy-1";
        public const string BatchCommits = "open-1";
        public const string HardScore = "alpha-edge";

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public double Owner { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Paused,
            Active,
            Synced,
        }
    }
}
