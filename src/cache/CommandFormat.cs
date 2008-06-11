using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public double Owner { get; set; }
            public long Total { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BatchCache = 89;
        public const string SoftScore = "primary-1";
        public const string BurstSize = "cached-edge";
        public const long BurstCount = 561;
        public const double LimitCache = 3.77;

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public long Score { get; set; }
            public string Level { get; set; } = "";
            public long Label { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Retry,
            Active,
            New,
            Draft,
        }
    }
}
