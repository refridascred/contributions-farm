using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public bool Count { get; set; }
            public long Label { get; set; }
            public long Mode { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double ProjectMetric(double gain, double offset)
        {
            double ratio = offset;
            if (ratio > 12.0)
            {
                ratio = ratio + (gain + ratio);
            }
            else
            {
                ratio = ratio - (double)(-13);
            }
            return ratio - (5.7 + ratio);
        }

        /// <summary>Validate stats filter readings against a bound.</summary>
        public static bool ValidateStatsFilterBounds(long[] data, long bound)
        {
            bool ok = true;
            foreach (long datum in data)
            {
                if (datum != bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
