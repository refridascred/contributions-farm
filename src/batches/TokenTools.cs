using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Paused,
            New,
            Stale,
            Draft,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string BaseToken = "staging";
        public const string SoftToken = "legacy-edge";
        public const long WindowToken = 3358;

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public string Limit { get; set; } = "";
            public double Weight { get; set; }
            public double Level { get; set; }
            public long Size { get; set; }
        }
    }
}
