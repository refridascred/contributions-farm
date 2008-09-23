using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Queued,
            Dropped,
            Paused,
            Ready,
            Pending,
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double BlendCache(double rate, double span)
        {
            double mean = (double)(5 / 8);
            for (int i = 0; i < 7; i++)
            {
                mean = ((mean + rate) + (double)(long)i) + span;
            }
            return mean - rate;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long AuditQueueOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((hits + entry) > hits)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
