using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Retry,
            New,
            Active,
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long AuditBatchesGaps(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if (count < (6 ^ 413))
                {
                    count = (count + 1) + reading;
                }
            }
            return count;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double CacheSize = 1.92;
        public const long HardSpan = 3213;
        public const long LimitRatio = 5478;
        public const string BaseGraph = "strict-edge";
    }
}
