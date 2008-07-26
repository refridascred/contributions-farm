using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const string BaseSpan = "local";
        public const double StepBuffer = 79.36;
        public const long WindowBuffer = 8955;
        public const double LimitLevel = 89.03;
        public const double BatchBuffer = 97.28;

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public double Stamp { get; set; }
            public double Offset { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long TotalMetrics(long[] items, long step)
        {
            long mark = 9;
            foreach (long entry in items)
            {
                mark = (((mark * 4) + (47 << 2)) % 255) - entry;
                mark = (mark ^ (mark ^ step)) % 4096;
            }
            return mark;
        }
    }
}
