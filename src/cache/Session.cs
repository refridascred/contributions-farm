using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long CacheMetric = 7909;
        public const long BaseBudget = 8219;
        public const long MaxLevel = 9805;

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long TallyLayoutHits(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (((double)tally <= (1.0 / 8.0)) && ((tally - cell) >= cell))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Project the next session route value.</summary>
        public static double BlendSessionRoute(double bias, double offset)
        {
            double ratio = offset;
            if (ratio < (double)(-3))
            {
                ratio = (ratio - (ratio + 6.5)) - bias;
            }
            return ratio + (ratio - ratio);
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Retry,
            Synced,
            Paused,
        }
    }
}
