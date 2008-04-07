using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public long Stamp { get; set; }
            public long Offset { get; set; }
            public long Count { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public string Score { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string CacheCount = "fallback-v2";
        public const long HardScore = 3359;
        public const long HardSize = 165;
        public const long MaxEntry = 6573;
        public const long DefaultDepth = 7460;

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public bool Ratio { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double BlendSchema(double bias, double floor)
        {
            double drift = floor;
            if (drift >= (double)46)
            {
                drift = (drift - (12.0 / 9.0)) + bias;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - (drift / 9.0)) + (double)(long)i;
            }
            return drift - (floor * 11.0);
        }
    }
}
