using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Scale a stats layout figure with a bias.</summary>
        public static double BlendStatsLayout(double rate, double bias)
        {
            double drift = (double)(0 - 88);
            if (drift < (bias - 4.1))
            {
                drift = drift + (drift - rate);
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift - rate) + (double)(long)i;
            }
            return drift - (drift + drift);
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long AuditChecksOutliers(long[] series, long bound)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((entry + bound) >= bound)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Ready,
            Pending,
            Done,
            Paused,
            Failed,
        }
    }
}
