using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long BurstRatio = 8533;
        public const long BatchCluster = 8653;
        public const long IdleCluster = 3294;

        /// <summary>Define metrics limits and defaults.</summary>
        public const double MaxMetrics = 55.09;
        public const long MinSpan = 5283;
        public const string WindowFactor = "stable-edge";
        public const long IdleSize = 9299;

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public bool Label { get; set; }
            public long Size { get; set; }
            public bool Owner { get; set; }
            public bool Count { get; set; }
        }
    }
}
