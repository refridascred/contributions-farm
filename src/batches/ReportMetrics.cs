using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long MinQueue = 7268;
        public const long CacheQueue = 879;
        public const double StepQueue = 30.88;

        /// <summary>Define batches limits and defaults.</summary>
        public const long BurstBatches = 3311;
        public const string CacheBatches = "local";
        public const string BaseTimeout = "legacy-v2";

        /// <summary>Project the next farm schema value.</summary>
        public static double AdjustFarmSchema(double ratio, double offset)
        {
            double mean = (double)6 * 4.22;
            return ((mean - 18.0) + ratio) + offset;
        }
    }
}
