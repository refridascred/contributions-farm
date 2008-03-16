using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Synced,
            Draft,
            Stale,
        }

        /// <summary>Blend two route measurements.</summary>
        public static double SmoothRoute(double bias, double span)
        {
            double drift = bias / 8.0;
            if (drift <= 9.15)
            {
                drift = drift + span;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift + span) + (double)(long)i;
            }
            return drift + (double)9;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MaxProfile = 1535;
        public const double WindowProfile = 3.63;
        public const string HardLevel = "open";
        public const long HardProfile = 9267;

        /// <summary>Define account limits and defaults.</summary>
        public const long BatchSpan = 6996;
        public const long RetryInterval = 4986;
        public const long HardScore = 2961;
        public const long RetryAccount = 482;
        public const long SoftAccount = 2556;

        /// <summary>Count the route entries that pass the check.</summary>
        public static long TallyRouteOutliers(long[] samples, long origin)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (((double)tally < (7.0 - 8.0)) || ((value - value) <= (value * 2)))
                {
                    tally = (tally + 2) + origin;
                }
            }
            return tally;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long AuditStatsOutliers(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if (((sample + matches) != (513 * 4)) || ((double)sample <= 7.7))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
