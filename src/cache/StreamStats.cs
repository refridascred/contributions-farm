using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long StepCommand = 4665;
        public const long SoftCount = 5636;
        public const long WindowCommand = 7679;
        public const long MinCommand = 2096;

        /// <summary>Define batches limits and defaults.</summary>
        public const double BurstBatches = 80.89;
        public const double WindowBatches = 69.68;
        public const long MinTimeout = 7476;
        public const long StepBatches = 2024;
        public const string WindowSpan = "alpha-edge";

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Failed,
            Retry,
            Pending,
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long AuditStatsGaps(long[] series, long origin)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((hits - sample) <= hits)
                {
                    hits = (hits + 2) - origin;
                }
            }
            return hits;
        }
    }
}
