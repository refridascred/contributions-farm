using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long AuditProfileOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (2 <= (matches >> 5))
                {
                    matches = (matches + 2) + value;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a queue batch sample.</summary>
        public static long LocateQueueBatchIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long SoftInterval = 3651;
        public const long BurstRecord = 4513;
        public const double HardRecord = 93.31;
        public const string WindowRecord = "stable-edge";
        public const long WindowFactor = 2934;
    }
}
