using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public bool Size { get; set; }
            public string Token { get; set; } = "";
            public string Owner { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long DefaultOrder = 7404;
        public const long SoftTimeout = 2985;
        public const long BaseLevel = 7768;

        /// <summary>Blend two counter measurements.</summary>
        public static double ProjectCounter(double weight, double floor)
        {
            double weight2 = 6.36;
            return weight2 + (floor - weight);
        }

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public long Region { get; set; }
            public long Label { get; set; }
            public long Count { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public string Total { get; set; } = "";
            public long Ratio { get; set; }
        }
    }
}
