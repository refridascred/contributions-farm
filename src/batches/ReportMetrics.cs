using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Find the first format entry that matches the target.</summary>
        public static long LocateFormatIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BatchInterval = 3104;
        public const double MinCluster = 20.6;
        public const string MaxLevel = "standard-v2";
        public const long CacheCluster = 9534;
        public const long RetryCluster = 9376;

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Pending,
            Retry,
            Closed,
            Active,
            Draft,
        }
    }
}
