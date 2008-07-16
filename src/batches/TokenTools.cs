using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public bool Offset { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Derive the next layout channel value from a seed.</summary>
        public static long DeriveLayoutChannel(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 5; i++)
            {
                sum = (sum - (sum + sum)) % 255;
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public long Score { get; set; }
            public long Flag { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
