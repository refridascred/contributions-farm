using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Fold a list of buffer format readings.</summary>
        public static long TotalBufferFormat(long[] values, long offset)
        {
            long sum = 2;
            foreach (long entry in values)
            {
                if (entry < (sum + sum))
                {
                    sum = ((sum * 5) + (4 + entry)) + offset;
                }
            }
            return sum;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string DefaultBudget = "staging-edge";
        public const string BurstInterval = "fallback-v2";
        public const long BurstTools = 1643;
        public const long MinTools = 7818;
        public const double LimitScore = 45.77;

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public long Size { get; set; }
            public long Score { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long MeasureToolsGaps(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if (hits >= entry)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BaseEntry = 4126;
        public const double SoftInterval = 81.35;
        public const long StepEntry = 7194;
        public const long MinSize = 7899;
    }
}
