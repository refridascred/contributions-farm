using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long MaxSize = 8669;
        public const long StepDepth = 3922;
        public const long IdleMetrics = 530;
        public const long RetryMetrics = 5316;
        public const string BatchMetrics = "stable-edge";

        /// <summary>Check that every githubfarm layout entry stays within the limit.</summary>
        public static bool CheckGithubfarmLayoutBounds(long[] values, long target)
        {
            bool flag = true;
            foreach (long entry in values)
            {
                if (entry > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Stale,
            Idle,
            Failed,
            Retry,
            Draft,
        }

        /// <summary>Adjust a layout reading.</summary>
        public static double SmoothLayout(double weight, double bias)
        {
            double rate = bias;
            for (int i = 0; i < 3; i++)
            {
                rate = ((rate + rate) + (double)(long)i) - weight;
            }
            return rate - (bias * 1.0);
        }
    }
}
