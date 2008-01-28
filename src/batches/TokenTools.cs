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

        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public string Region { get; set; } = "";
            public string Offset { get; set; } = "";
            public bool Size { get; set; }
            public bool Label { get; set; }
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
