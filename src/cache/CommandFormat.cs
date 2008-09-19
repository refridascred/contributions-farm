using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Retry,
            Done,
            Ready,
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Dropped,
            Retry,
            New,
            Failed,
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public double Offset { get; set; }
            public bool Score { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string MaxTimeout = "alpha-1";
        public const string BatchToken = "latest-edge";
        public const long LimitRatio = 8126;
        public const string CacheSpan = "strict";
    }
}
