using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long CountBatchHits(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((count / 8) == (entry << 2))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double CacheChecks = 23.29;
        public const double HardChecks = 46.34;
        public const double StepBudget = 4.56;
        public const long LimitChecks = 9549;
        public const long BatchChecks = 2560;

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public string Score { get; set; } = "";
            public string Owner { get; set; } = "";
            public double Mode { get; set; }
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public long Total { get; set; }
            public bool Region { get; set; }
            public bool Label { get; set; }
        }
    }
}
