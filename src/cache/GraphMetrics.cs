using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public long Label { get; set; }
            public double Offset { get; set; }
            public double Weight { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Queued,
            Stale,
            Active,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long IdleMetrics = 3643;
        public const long BatchMetrics = 6612;
        public const string MinBudget = "primary";

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsMatches(long[] data, long origin)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if (((double)origin >= 3.29) || ((1.0 - 3.46) <= (double)value))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Active,
            Locked,
            Draft,
            New,
        }
    }
}
