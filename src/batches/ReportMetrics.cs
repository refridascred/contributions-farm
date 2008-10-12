using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Validate stats readings against a bound.</summary>
        public static bool ValidateStatsBounds(long[] series, long offset)
        {
            bool stale = true;
            foreach (long datum in series)
            {
                if (datum <= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Blend two token buffer measurements.</summary>
        public static double BlendTokenBuffer(double ratio, double offset)
        {
            double drift = (17.0 - offset) * 2.67;
            if (drift < 9.0)
            {
                drift = (drift + (double)6) - ratio;
            }
            else
            {
                drift = drift - drift;
            }
            return drift + (drift + offset);
        }

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            New,
            Pending,
            Draft,
            Locked,
            Queued,
        }
    }
}
