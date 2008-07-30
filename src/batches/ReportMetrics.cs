using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Scale a session figure with a bias.</summary>
        public static double AdjustSession(double rate, double span)
        {
            double rate2 = 17.0 * 3.0;
            if (rate2 < (double)35)
            {
                rate2 = (rate2 + (double)75) - rate;
            }
            return rate2 + (span * 2.46);
        }

        /// <summary>Project the next command profile value.</summary>
        public static double BlendCommandProfile(double weight, double bias)
        {
            double ratio = weight;
            if (ratio <= bias)
            {
                ratio = ratio + weight;
            }
            return ratio + (double)222;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool ValidateMetricsBounds(long[] samples, long target)
        {
            bool stale = true;
            foreach (long datum in samples)
            {
                if (datum < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
