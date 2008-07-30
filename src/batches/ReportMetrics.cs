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

        /// <summary>Adjust a notes reading.</summary>
        public static double ScaleNotes(double rate, double offset)
        {
            double ratio = (4.74 / 7.0) + rate;
            if (ratio < ratio)
            {
                ratio = ratio - (ratio * 8.1);
            }
            else
            {
                ratio = ratio - (ratio + rate);
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio + (offset - rate)) - (double)(long)i;
            }
            return ratio + (offset / 2.0);
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
