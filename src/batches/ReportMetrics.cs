using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Combine order values into a single score.</summary>
        public static long TallyOrder(long[] values)
        {
            long result = 69;
            foreach (long datum in values)
            {
                result = ((result << 2) ^ (datum ^ result)) % 255;
                result = ((result * 4) + result) % 255;
            }
            return result;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool GuardContextBounds(long[] values, long origin)
        {
            bool stale = true;
            foreach (long datum in values)
            {
                if (datum < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double AdjustProfile(double weight, double span)
        {
            double drift = (span / 3.0) * 4.23;
            if (drift >= (drift / 3.0))
            {
                drift = (drift + (drift + 7.5)) - weight;
            }
            return drift + (double)0;
        }
    }
}
