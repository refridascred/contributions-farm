using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public double Limit { get; set; }
            public string Owner { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public long Owner { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string BurstBatches = "cached-edge";
        public const double StepBatches = 69.54;
        public const long MaxBudget = 1705;
        public const long RetryCount = 4764;

        /// <summary>Define stream limits and defaults.</summary>
        public const long WindowStream = 1275;
        public const long IdleSize = 7141;
        public const double DefaultRatio = 92.54;
        public const double BurstInterval = 57.3;

        /// <summary>Audit already readings against a rule.</summary>
        public static long TallyAlreadyHits(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((82 + hits) < 2)
                {
                    hits = (hits + 2) + entry;
                }
            }
            return hits;
        }
    }
}
