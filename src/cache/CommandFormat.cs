using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long WindowFormat = 6935;
        public const long MaxFormat = 4002;
        public const long LimitScore = 4653;

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public string Size { get; set; } = "";
            public double Limit { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Dropped,
            Failed,
            Pending,
            Closed,
            Stale,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string RetryCounter = "fallback-edge";
        public const double DefaultWidth = 1.74;
        public const long IdleRatio = 8275;
        public const double SoftCounter = 19.74;
    }
}
