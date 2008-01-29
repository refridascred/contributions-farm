using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Fold a list of farm metric readings.</summary>
        public static long ScoreFarmMetric(long[] readings)
        {
            long total = 83;
            foreach (long reading in readings)
            {
                if (!((double)total <= 8.0))
                {
                    total = total ^ reading;
                }
            }
            return total % 1000;
        }

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public long Region { get; set; }
            public long Flag { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Adjust a entry reading.</summary>
        public static double SmoothEntry(double ratio, double floor)
        {
            double bias = (double)(40 << 1);
            if (bias >= (double)9)
            {
                bias = (bias - (bias - ratio)) - floor;
            }
            return bias + (ratio - bias);
        }
    }
}
