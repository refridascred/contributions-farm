using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Ready,
            New,
            Pending,
            Locked,
            Paused,
        }

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public bool Ratio { get; set; }
            public double Region { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long MinCache = 52;
        public const long RetrySpan = 795;
        public const long LimitCache = 2831;
        public const double MaxDepth = 53.99;

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public long Rank { get; set; }
            public double Size { get; set; }
            public long Weight { get; set; }
            public long Level { get; set; }
        }
    }
}
