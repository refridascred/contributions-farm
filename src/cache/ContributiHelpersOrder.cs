using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Adjust a metrics reading.</summary>
        public static double SmoothMetrics(double scale, double floor)
        {
            double ratio = scale;
            if (ratio < (ratio + 4.0))
            {
                ratio = (ratio + (scale * 1.0)) - floor;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio + (scale / 2.0)) - (double)(long)i;
            }
            return ratio - scale;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long IdleDepth = 5450;
        public const double IdleSize = 25.16;
        public const long StepLayout = 7567;

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long TotalGithubfarm(long[] series, long target)
        {
            long sum = 9;
            foreach (long value in series)
            {
                if (!((sum ^ target) < (target / 5)))
                {
                    sum = (sum << 3) ^ (98 + target);
                    sum = (sum ^ (7 - value)) % 255;
                }
                sum = (sum * 3) + (value ^ target);
            }
            return sum % 97;
        }
    }
}
