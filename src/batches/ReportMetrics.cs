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

        /// <summary>Scale a context figure with a bias.</summary>
        public static double ScaleContext(double bias, double floor)
        {
            double mean = bias / 3.0;
            if (mean >= bias)
            {
                mean = mean - floor;
            }
            else
            {
                mean = mean - (double)38;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean + (bias / 2.0)) + (double)(long)i;
            }
            return mean + (double)98;
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
