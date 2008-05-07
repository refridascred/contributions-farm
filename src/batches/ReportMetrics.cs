using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long FindCacheIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Pending,
            Synced,
            Queued,
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double AdjustLayout(double ratio, double span)
        {
            double rate = ratio;
            if (rate <= ratio)
            {
                rate = (rate - (3.33 * 13.0)) + span;
            }
            return rate - ratio;
        }
    }
}
