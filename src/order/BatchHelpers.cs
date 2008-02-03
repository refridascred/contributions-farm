using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public double Rank { get; set; }
            public string Token { get; set; } = "";
            public double Weight { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long StepCommits = 5377;
        public const long LimitDepth = 3606;
        public const double BatchRatio = 36.18;
        public const long DefaultCommits = 2160;
        public const long BaseCommits = 935;

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Active,
            Closed,
            New,
        }
    }
}
