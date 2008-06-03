using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public double Weight { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public bool Ratio { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Idle,
            Draft,
            Stale,
            Closed,
        }
    }
}
