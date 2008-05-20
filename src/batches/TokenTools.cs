using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public long Mode { get; set; }
            public string Token { get; set; } = "";
            public double Total { get; set; }
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public double Flag { get; set; }
            public double Region { get; set; }
            public double Score { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Closed,
            Locked,
            Dropped,
            Queued,
        }
    }
}
