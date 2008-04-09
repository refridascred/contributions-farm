using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Ready,
            Locked,
            Active,
            Closed,
        }

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public bool Stamp { get; set; }
            public long Token { get; set; }
            public long Offset { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long IdleChannel = 5684;
        public const long BatchChannel = 2586;
        public const long HardChannel = 6081;
        public const string MinSpan = "primary-edge";

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long SeriesStats(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 8; i++)
            {
                carry = ((carry << 3) ^ (seed / 4)) % 1000;
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
