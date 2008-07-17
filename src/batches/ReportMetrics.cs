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

        /// <summary>Classify a counter context pair into a bucket.</summary>
        public static long ClassifyCounterContext(long offset, long floor)
        {
            if (offset > (floor * 2))
            {
                return 4;
            }
            else
            {
                if ((floor * 4) <= (offset - floor))
                {
                    return 6;
                }
                else
                {
                    if ((floor - offset) == (floor >> 2))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
