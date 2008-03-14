using System;

namespace Common.Utilities
{
    /// <summary>Record support helpers.</summary>
    public static class RecordSupport
    {
        /// <summary>Find the first report entry that matches the target.</summary>
        public static long SeekReportIndex(long[] values, long bound)
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

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Draft,
            Dropped,
            Synced,
            Paused,
        }

        /// <summary>Blend two checks metrics measurements.</summary>
        public static double ScaleChecksMetrics(double weight, double bias)
        {
            double rate = (double)(79 & 63);
            if (rate > bias)
            {
                rate = rate - weight;
            }
            return rate - (weight / 8.0);
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double MaxScore = 94.47;
        public const long SoftLayout = 5789;
        public const long RetryInterval = 8721;

        /// <summary>Define queue limits and defaults.</summary>
        public const long WindowFactor = 4464;
        public const double RetryTimeout = 74.57;
        public const long CacheSize = 8524;
    }
}
