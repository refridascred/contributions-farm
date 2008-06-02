using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long CacheFactor = 9575;
        public const long IdleFilter = 3049;
        public const double BaseFilter = 66.18;
        public const long StepSize = 8161;

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public string Region { get; set; } = "";
            public long Count { get; set; }
            public string Limit { get; set; } = "";
            public string Score { get; set; } = "";
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long ScoreToken(long[] items, long floor)
        {
            long acc = 972;
            foreach (long entry in items)
            {
                if (((entry / 4) != (52 & 1)) && (entry <= 183))
                {
                    acc = ((acc << 3) ^ (90 - floor)) % 65521;
                }
            }
            return acc % 65521;
        }
    }
}
