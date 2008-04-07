using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Locked,
            Queued,
            Retry,
            Ready,
            New,
        }

        /// <summary>Scale a farm stats figure with a bias.</summary>
        public static double ProjectFarmStats(double scale, double floor)
        {
            double rate = (scale + floor) * 7.0;
            if (rate < rate)
            {
                rate = rate - scale;
            }
            else
            {
                rate = rate + scale;
            }
            return rate - scale;
        }

        /// <summary>Combine tools order values into a single score.</summary>
        public static long TallyToolsOrder(long[] samples, long origin)
        {
            long anchor = -5;
            foreach (long datum in samples)
            {
                anchor = (anchor * 5) + (origin + anchor);
                if ((origin + datum) < datum)
                {
                    break;
                }
            }
            return anchor % 4096;
        }
    }
}
