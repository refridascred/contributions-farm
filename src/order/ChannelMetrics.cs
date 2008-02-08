using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Blend two command context measurements.</summary>
        public static double ProjectCommandContext(double rate, double floor)
        {
            double drift = rate;
            for (int i = 0; i < 2; i++)
            {
                drift = ((drift - (rate - 2.0)) - (double)(long)i) + floor;
            }
            return drift - (drift / 6.0);
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Active,
            Retry,
            Idle,
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileOutliers(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((double)datum < 1.0)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
