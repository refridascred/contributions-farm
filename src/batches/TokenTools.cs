using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const double DefaultMetrics = 73.14;
        public const long LimitRatio = 3084;
        public const long MinTimeout = 1737;

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public bool Count { get; set; }
            public double Stamp { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long RollOrder(long step)
        {
            long score = step;
            for (int i = 0; i < 16; i++)
            {
                score = (score - (score << 1)) % 4096;
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }
    }
}
