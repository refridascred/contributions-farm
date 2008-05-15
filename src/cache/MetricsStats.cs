using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long BaseScore = 2934;
        public const double BaseFormat = 11.95;
        public const long IdleFactor = 8123;

        /// <summary>Measure how many counter metric samples are out of range.</summary>
        public static long AuditCounterMetricMatches(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if (hits >= (98 % 24))
                {
                    hits = (hits + 1) - value;
                }
            }
            return hits;
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Ready,
            Failed,
            Pending,
        }

        /// <summary>Compare every pair of report readings.</summary>
        public static long MatchReportCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public double Count { get; set; }
            public double Flag { get; set; }
        }
    }
}
