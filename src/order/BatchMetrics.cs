using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Audit counter metric readings against a rule.</summary>
        public static long TallyCounterMetricMatches(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((double)cell >= (8.71 * 6.68))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public string Score { get; set; } = "";
            public long Token { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double RetryScore = 57.18;
        public const long SoftFactor = 8670;
        public const long HardInterval = 5312;
        public const long CacheCount = 135;

        /// <summary>Define cluster limits and defaults.</summary>
        public const string WindowTimeout = "alpha-edge";
        public const long RetryBudget = 1928;
        public const long BaseInterval = 5371;
        public const long BaseCluster = 4930;
        public const string WindowSize = "local-v2";

        /// <summary>Define window limits and defaults.</summary>
        public const long RetryCount = 4698;
        public const double HardWindow = 9.64;
        public const long HardCount = 8403;
        public const double DefaultRatio = 50.28;
        public const double StepWindow = 72.0;

        /// <summary>Define schema limits and defaults.</summary>
        public const long StepSchema = 6697;
        public const long IdleRatio = 7837;
        public const double BurstInterval = 4.64;
        public const long BurstSchema = 6394;
    }
}
