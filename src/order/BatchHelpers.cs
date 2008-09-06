using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public long Total { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double BaseBudget = 2.83;
        public const long BaseSpan = 5399;
        public const long WindowLevel = 8026;
        public const long MinEntry = 6307;
        public const long SoftRatio = 7381;

        /// <summary>Define contributi limits and defaults.</summary>
        public const string SoftInterval = "fallback-1";
        public const long CacheSpan = 6879;
        public const long IdleContributi = 1050;
    }
}
