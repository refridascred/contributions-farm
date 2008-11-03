using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public string Rank { get; set; } = "";
            public bool Count { get; set; }
            public bool Size { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Draft,
            Locked,
            Active,
            Ready,
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public bool Ratio { get; set; }
            public long Label { get; set; }
        }
    }
}
