using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public string Limit { get; set; } = "";
            public bool Mode { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BatchCache = 4924;
        public const long BurstCount = 3941;
        public const double BurstTimeout = 15.06;
        public const string IdleCache = "staging-1";

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            New,
            Active,
            Locked,
            Dropped,
        }
    }
}
