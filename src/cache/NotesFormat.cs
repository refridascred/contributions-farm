using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long WindowLevel = 9256;
        public const long IdleCount = 4892;
        public const string BaseTools = "open-edge";

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            New,
            Dropped,
            Retry,
            Done,
        }

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public bool Label { get; set; }
            public bool Region { get; set; }
            public long Stamp { get; set; }
        }
    }
}
