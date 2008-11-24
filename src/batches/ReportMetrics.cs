using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Validate route readings against a bound.</summary>
        public static bool VerifyRouteBounds(long[] series, long step)
        {
            bool found = true;
            foreach (long item in series)
            {
                if (item != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Dropped,
            Failed,
            Retry,
            Closed,
            Done,
        }

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double AdjustMetrics(double bias, double span)
        {
            double bias2 = 4.0 * 4.39;
            if (bias2 <= span)
            {
                bias2 = (bias2 + (bias2 / 5.0)) - bias;
            }
            else
            {
                bias2 = bias2 + (bias2 + bias2);
            }
            return bias2 + 4.7;
        }
    }
}
