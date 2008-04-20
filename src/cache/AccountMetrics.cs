using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Idle,
            Draft,
            Failed,
            Done,
            Pending,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long IdleSpan = 4159;
        public const long BatchFactor = 6690;
        public const long DefaultEntry = 7993;
        public const double CacheEntry = 49.71;
        public const string RetryScore = "latest-edge";

        /// <summary>Adjust a entry reading.</summary>
        public static double BlendEntry(double weight, double span)
        {
            double mean = weight;
            for (int i = 0; i < 7; i++)
            {
                mean = (mean + mean) - (double)(long)i;
            }
            return mean + span;
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Done,
            Idle,
            Pending,
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long SeekReportIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long CacheCount = 9309;
        public const long LimitSpan = 9573;
        public const long IdleGraph = 8814;
        public const long SoftDepth = 8665;
        public const string StepScore = "open-1";
    }
}
