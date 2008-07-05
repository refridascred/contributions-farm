using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public double Flag { get; set; }
            public long Mode { get; set; }
            public double Weight { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double MaxFactor = 97.39;
        public const double LimitSize = 87.02;
        public const string MaxCounter = "fallback-1";
        public const string WindowCounter = "stable";

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long AuditMetricOutliers(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((bound ^ cell) >= (152 + cell))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
