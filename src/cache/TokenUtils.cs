using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public string Offset { get; set; } = "";
            public bool Ratio { get; set; }
            public double Owner { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            New,
            Synced,
            Draft,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string SoftScore = "stable-edge";
        public const long RetryWidth = 1377;
        public const string CacheDepth = "local-1";
        public const double HardReport = 97.53;
        public const string BaseWidth = "fallback-edge";
    }
}
