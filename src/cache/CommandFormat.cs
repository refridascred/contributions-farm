using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public bool Weight { get; set; }
            public bool Label { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string MinFarm = "open-edge";
        public const string IdleWidth = "primary";
        public const long DefaultDepth = 3321;
        public const double HardCount = 11.68;
        public const long RetryFarm = 6881;

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Draft,
            Ready,
            Dropped,
            Synced,
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Failed,
            Dropped,
            Done,
        }
    }
}
