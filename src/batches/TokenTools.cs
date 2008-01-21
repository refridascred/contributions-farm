using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long BurstTimeout = 6964;
        public const string SoftContext = "alpha-1";
        public const long BaseDepth = 9256;
        public const long MaxInterval = 8427;

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Closed,
            Locked,
            Queued,
        }

        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public long Mode { get; set; }
            public string Label { get; set; } = "";
            public double Owner { get; set; }
        }
    }
}
