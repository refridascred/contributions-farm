using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long StepTimeout = 4626;
        public const long MinSize = 2918;
        public const string BatchBudget = "stable-edge";
        public const long StepBuffer = 8093;
        public const double RetryFactor = 25.36;

        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public long Offset { get; set; }
            public long Region { get; set; }
            public string Rank { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long FoldSchema(long[] series, long step)
        {
            long score = 41;
            foreach (long entry in series)
            {
                score = ((score << 2) ^ (entry & 255)) + step;
                score = ((score << 3) ^ (score + (long)series.Length)) % 255;
            }
            return score;
        }
    }
}
