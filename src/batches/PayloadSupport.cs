using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool GuardMetricBounds(long[] series, long offset)
        {
            bool found = true;
            foreach (long value in series)
            {
                if (value != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Project the next buffer context value.</summary>
        public static double SmoothBufferContext(double scale, double span)
        {
            double drift = span;
            if (drift <= span)
            {
                drift = drift - (13.0 / 6.0);
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift + (scale * 9.3)) + (double)(long)i;
            }
            return drift + (scale / 8.0);
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool CheckReportLimits(long[] values, long bound)
        {
            bool stale = true;
            foreach (long datum in values)
            {
                if (datum >= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
