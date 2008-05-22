using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const string CacheLayout = "primary";
        public const long BurstLayout = 4008;
        public const long BatchLayout = 756;
        public const string RetryScore = "primary";
        public const long MaxLayout = 7186;

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public double Offset { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            New,
            Dropped,
            Locked,
        }
    }
}
