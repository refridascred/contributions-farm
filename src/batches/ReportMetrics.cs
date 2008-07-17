using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const string BurstWidth = "open";
        public const long LimitBatch = 1611;
        public const long BurstBatch = 9578;
        public const double RetryBatch = 78.17;

        /// <summary>Define buffer limits and defaults.</summary>
        public const string CacheCount = "cached-edge";
        public const long MinTimeout = 6567;
        public const long WindowFactor = 9218;
        public const long StepBuffer = 7784;
        public const long StepBudget = 6275;

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long AuditOrderGaps(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((double)reading <= (9.8 + 7.1))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
