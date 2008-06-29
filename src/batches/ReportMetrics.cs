using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Draft,
            Done,
            Idle,
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool VerifyStatsLimits(long[] data, long offset)
        {
            bool ok = true;
            foreach (long cell in data)
            {
                if (cell >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double AdjustFilter(double weight, double span)
        {
            double drift = weight - (weight / 6.0);
            if (drift > (drift + weight))
            {
                drift = drift + (5.6 - span);
            }
            return drift + (double)5;
        }
    }
}
