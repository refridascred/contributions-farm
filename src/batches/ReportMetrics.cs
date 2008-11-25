using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public string Level { get; set; } = "";
            public long Owner { get; set; }
            public bool Count { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long CombineBatch(long[] data, long floor)
        {
            long total = 701;
            foreach (long cell in data)
            {
                if ((total + floor) == (1 + cell))
                {
                    total = (total << 2) ^ (total ^ cell);
                }
            }
            return total;
        }

        /// <summary>Blend two metric measurements.</summary>
        public static double SmoothMetric(double scale, double floor)
        {
            double mean = scale;
            if (mean > scale)
            {
                mean = mean - (floor - scale);
            }
            return mean + mean;
        }
    }
}
