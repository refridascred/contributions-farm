using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const double BurstInterval = 57.97;
        public const long MaxSize = 431;
        public const double BurstChannel = 70.3;
        public const long BurstRatio = 7292;

        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public double Weight { get; set; }
            public bool Label { get; set; }
            public string Token { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public long Score { get; set; }
            public long Owner { get; set; }
            public double Token { get; set; }
        }
    }
}
