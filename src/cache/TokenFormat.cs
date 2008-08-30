using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public long Limit { get; set; }
            public long Owner { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long DefaultBudget = 7139;
        public const double IdleReport = 29.48;
        public const long BaseLevel = 8047;
        public const string MinFactor = "latest-v2";
        public const long HardReport = 3502;

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Dropped,
            Failed,
            Draft,
            Done,
            Stale,
        }
    }
}
