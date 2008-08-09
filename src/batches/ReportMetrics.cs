using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutGaps(long[] values, long limit)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((hits / 2) < (1 + 8))
                {
                    hits = ((hits + 3) ^ value) + limit;
                }
            }
            return hits;
        }

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public double Stamp { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Blend two buffer report measurements.</summary>
        public static double ProjectBufferReport(double weight, double floor)
        {
            double gain = weight / 2.0;
            if (gain >= weight)
            {
                gain = gain + (floor / 3.0);
            }
            else
            {
                gain = gain + weight;
            }
            return gain + floor;
        }
    }
}
