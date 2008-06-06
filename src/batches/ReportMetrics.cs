using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Combine graph values into a single score.</summary>
        public static long FoldGraph(long[] samples, long offset)
        {
            long acc = 7;
            foreach (long item in samples)
            {
                acc = ((acc - (item & 3)) % 4096) - offset;
            }
            return acc % 65521;
        }

        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long MatchCommandCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public long Weight { get; set; }
            public long Total { get; set; }
            public long Ratio { get; set; }
        }
    }
}
