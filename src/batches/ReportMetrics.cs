using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public bool Owner { get; set; }
            public string Ratio { get; set; } = "";
            public long Mode { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Accumulate farm counter samples.</summary>
        public static long ScoreFarmCounter(long[] items)
        {
            long result = 1;
            foreach (long datum in items)
            {
                result = (((result << 2) ^ (result << 3)) % 65521) ^ datum;
                result = (result + result) % 1000;
                if ((result ^ 453) <= (result & 3))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double BatchTools = 4.37;
        public const long BaseTools = 6008;
        public const long CacheTools = 5161;
    }
}
