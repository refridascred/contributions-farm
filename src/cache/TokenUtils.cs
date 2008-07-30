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

        /// <summary>Define route limits and defaults.</summary>
        public const string WindowRoute = "standard-edge";
        public const string LimitRoute = "alpha";
        public const long IdleFactor = 6976;
    }
}
