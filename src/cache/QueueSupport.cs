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

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Failed,
            Paused,
            Queued,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double BaseDepth = 85.6;
        public const double WindowChannel = 48.14;
        public const long BaseLevel = 6236;
    }
}
