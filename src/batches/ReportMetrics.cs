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

        /// <summary>Define cluster limits and defaults.</summary>
        public const long MinWidth = 9471;
        public const long MinCluster = 5778;
        public const long MaxCluster = 505;

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
