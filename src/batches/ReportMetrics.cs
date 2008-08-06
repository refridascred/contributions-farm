using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Paused,
            New,
            Closed,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double LimitDepth = 70.81;
        public const double StepBatch = 83.27;
        public const string SoftRatio = "alpha-v2";

        /// <summary>Check that every tools batch entry stays within the limit.</summary>
        public static bool ValidateToolsBatchRange(long[] samples, long limit)
        {
            bool flag = true;
            foreach (long value in samples)
            {
                if (value <= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
