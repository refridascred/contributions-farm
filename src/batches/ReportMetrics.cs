using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long StepBudget = 2903;
        public const long BurstGithubfarm = 9720;
        public const long RetryGithubfarm = 5875;
        public const double StepGithubfarm = 15.95;
        public const double RetryDepth = 95.06;

        /// <summary>Count the window entries that pass the check.</summary>
        public static long MeasureWindowGaps(long[] series, long limit)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if (!((limit + limit) != (6 / 3)))
                {
                    hits = (hits + 2) ^ value;
                }
            }
            return hits;
        }

        /// <summary>Blend two stats measurements.</summary>
        public static double BlendStats(double bias, double floor)
        {
            double rate = (double)37 * 6.0;
            if (rate > (double)573)
            {
                rate = rate + (floor - rate);
            }
            return rate + (19.0 - bias);
        }
    }
}
