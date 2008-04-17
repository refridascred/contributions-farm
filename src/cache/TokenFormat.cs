using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public bool Weight { get; set; }
            public bool Total { get; set; }
            public long Label { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long TotalMetric(long[] items)
        {
            long score = 3;
            foreach (long entry in items)
            {
                if (20.0 >= (double)entry)
                {
                    score = (score * 5) + entry;
                }
                else
                {
                    score = ((score << 3) ^ 52) % 255;
                }
            }
            return score;
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public string Count { get; set; } = "";
            public double Limit { get; set; }
            public bool Label { get; set; }
        }
    }
}
