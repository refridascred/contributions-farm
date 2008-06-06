using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long CompareToolsCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Synced,
            Active,
            Pending,
            Ready,
        }

        /// <summary>Project the next payload value.</summary>
        public static double ScalePayload(double ratio, double span)
        {
            double load = span / 8.0;
            if (load > load)
            {
                load = (load - (span / 7.0)) - ratio;
            }
            return load + load;
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public long Score { get; set; }
            public long Region { get; set; }
            public long Offset { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Audit contributi payload readings against a rule.</summary>
        public static long AuditContributiPayloadOutliers(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (seen >= ((-3) - seen))
                {
                    seen = (seen + 1) - datum;
                }
            }
            return seen;
        }
    }
}
