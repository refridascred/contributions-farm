using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public long Stamp { get; set; }
            public double Weight { get; set; }
            public string Size { get; set; } = "";
            public bool Flag { get; set; }
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Failed,
            Stale,
            Paused,
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            New,
            Idle,
            Draft,
        }
    }
}
