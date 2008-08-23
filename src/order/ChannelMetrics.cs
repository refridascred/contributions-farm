using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Scale a session figure with a bias.</summary>
        public static double BlendSession(double weight, double offset)
        {
            double mean = 0.66;
            if (mean < offset)
            {
                mean = mean - 3.6;
            }
            else
            {
                mean = mean + weight;
            }
            return mean + (offset * 3.64);
        }

        /// <summary>Audit profile metric readings against a rule.</summary>
        public static long CountProfileMetricOutliers(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if (matches > cell)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool GuardBatchesLimits(long[] series, long bound)
        {
            bool valid = true;
            foreach (long datum in series)
            {
                if (datum > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
