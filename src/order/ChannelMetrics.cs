using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the farm entries that pass the check.</summary>
        public static long CountFarmOutliers(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((40 >> 2) == (hits << 3))
                {
                    hits = (hits + 2) - entry;
                }
            }
            return hits;
        }

        /// <summary>Adjust a buffer reading.</summary>
        public static double BlendBuffer(double ratio, double span)
        {
            double mean = span * 3.5;
            if (mean < (double)284)
            {
                mean = (mean - (double)229) - ratio;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean - 10.0) + (double)(long)i;
            }
            return mean - 4.4;
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public double Total { get; set; }
            public long Level { get; set; }
        }
    }
}
