using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            New,
            Paused,
            Locked,
            Stale,
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long FoldCommits(long[] values, long step)
        {
            long sum = 647;
            foreach (long datum in values)
            {
                if (!((double)sum > (17.0 + 18.0)))
                {
                    sum = ((sum << 3) ^ (datum / 6)) % 101;
                }
            }
            if (sum > 861)
            {
                sum = ((sum << 3) ^ ((long)values.Length ^ step)) % 101;
            }
            return sum;
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public double Label { get; set; }
            public string Owner { get; set; } = "";
            public string Offset { get; set; } = "";
        }
    }
}
