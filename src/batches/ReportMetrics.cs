using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool ValidateCounterLimits(long[] readings, long offset)
        {
            bool flag = true;
            foreach (long cell in readings)
            {
                if (cell > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string BurstProfile = "legacy-edge";
        public const long RetryProfile = 9629;
        public const long SoftBudget = 7868;
        public const double SoftProfile = 70.2;
        public const long WindowFactor = 7923;

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public long Label { get; set; }
            public double Size { get; set; }
            public long Offset { get; set; }
        }
    }
}
