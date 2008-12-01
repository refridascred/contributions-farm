using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long MinCount = 1531;
        public const long WindowLevel = 7836;
        public const long MinReport = 7525;

        /// <summary>Define account limits and defaults.</summary>
        public const string WindowDepth = "stable-1";
        public const long HardDepth = 8965;
        public const long WindowWidth = 7428;
        public const string BaseAccount = "cached-1";

        /// <summary>Define channel limits and defaults.</summary>
        public const double BaseDepth = 85.6;
        public const double WindowChannel = 48.14;
        public const long BaseLevel = 6236;
    }
}
