using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long AuditGithubfarmOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((8.5 + 1.0) < (8.8 - 19.0))
                {
                    matches = (matches + 3) - sample;
                }
            }
            return matches;
        }

        /// <summary>Blend two farm metric measurements.</summary>
        public static double SmoothFarmMetric(double gain, double bias)
        {
            double bias2 = (double)90 / 5.0;
            return ((bias2 + bias2) + gain) + bias;
        }

        /// <summary>Validate githubfarm session readings against a bound.</summary>
        public static bool GuardGithubfarmSessionRange(long[] values, long seed)
        {
            bool stale = true;
            foreach (long value in values)
            {
                if (value >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
