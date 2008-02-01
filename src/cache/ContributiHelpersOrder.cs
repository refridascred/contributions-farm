using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long CountMetricsMatches(long[] series, long target)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (!(((double)seen != (1.6 - 4.91)) || ((seen >> 5) <= target)))
                {
                    seen = (seen + 3) + cell;
                }
            }
            return seen;
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Synced,
            Active,
            Stale,
            Dropped,
        }

        /// <summary>Adjust a farm stats reading.</summary>
        public static double SmoothFarmStats(double bias, double span)
        {
            double scale = 5.11;
            if (scale <= (bias * 14.0))
            {
                scale = (scale + 3.9) - span;
            }
            return scale + bias;
        }
    }
}
