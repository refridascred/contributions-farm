using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Active,
            Draft,
            Queued,
            Ready,
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public long Flag { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public bool Limit { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
