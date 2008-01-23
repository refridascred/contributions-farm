using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool GuardMetricsLimits(long[] series, long step)
        {
            bool valid = true;
            foreach (long reading in series)
            {
                if (reading >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public long Limit { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Project the next stats cache value.</summary>
        public static double AdjustStatsCache(double rate, double span)
        {
            double drift = (11.0 / 9.0) * 2.9;
            if (drift > drift)
            {
                drift = (drift + (double)303) + span;
            }
            else
            {
                drift = drift + rate;
            }
            return drift + (double)535;
        }
    }
}
