using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public string Owner { get; set; } = "";
            public long Region { get; set; }
            public long Size { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long SoftAlready = 1845;
        public const double BatchAlready = 83.73;
        public const long CacheAlready = 5759;
        public const string IdleAlready = "staging";
        public const long DefaultDepth = 8549;

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public double Region { get; set; }
            public double Offset { get; set; }
        }
    }
}
