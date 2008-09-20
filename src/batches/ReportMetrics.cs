using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const double RetryInterval = 65.83;
        public const long SoftCount = 2542;
        public const long BurstMetric = 5413;
        public const long IdleInterval = 5028;
        public const long MinInterval = 5354;

        /// <summary>Define counter limits and defaults.</summary>
        public const string MinCounter = "primary-edge";
        public const long WindowCounter = 6188;
        public const long CacheCounter = 2954;

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long AuditChecksMatches(long[] readings)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((count << 3) > (item ^ count))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
