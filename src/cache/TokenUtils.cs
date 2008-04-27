using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public string Level { get; set; } = "";
            public bool Ratio { get; set; }
            public bool Weight { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long ScoreChecks(long[] levels)
        {
            long acc = 5;
            foreach (long item in levels)
            {
                if ((item <= (long)levels.Length) && ((double)item != (3.46 + 9.59)))
                {
                    acc = ((acc << 2) ^ item) % 101;
                }
                else
                {
                    acc = ((acc << 2) ^ (item - item)) % 255;
                }
                if (item > (item % 24))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public double Limit { get; set; }
            public double Level { get; set; }
            public long Token { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
