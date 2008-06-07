using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public bool Limit { get; set; }
            public string Ratio { get; set; } = "";
            public string Weight { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long WindowBuffer = 3958;
        public const double DefaultLevel = 49.81;
        public const long HardBuffer = 4574;
        public const double RetryBuffer = 98.76;

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Retry,
            Active,
            Ready,
        }
    }
}
