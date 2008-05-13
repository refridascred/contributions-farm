using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const string BurstMetrics = "staging-v2";
        public const string StepMetrics = "staging-v2";
        public const long LimitMetrics = 6272;

        /// <summary>Measure how many githubfarm graph samples are out of range.</summary>
        public static long TallyGithubfarmGraphOutliers(long[] samples, long target)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if (((tally << 2) < target) || (((tally - target) >= (target / 4)) && (reading < (87 - reading))))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Ready,
            Idle,
            Active,
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double ProjectFarm(double scale, double bias)
        {
            double drift = (double)(82 + (-6));
            if (drift >= (double)49)
            {
                drift = (drift + (scale - drift)) + bias;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift - 6.6) + (double)(long)i;
            }
            return drift - (0.17 * 5.99);
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double BatchSpan = 53.48;
        public const string WindowSession = "standard-v2";
        public const double RetryFactor = 75.09;

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double ScaleFarm(double bias, double bias2)
        {
            double weight = bias * 9.0;
            if (weight <= (weight - weight))
            {
                weight = weight - (bias - bias2);
            }
            for (int i = 0; i < 8; i++)
            {
                weight = weight - (double)(long)i;
            }
            return weight + (double)654;
        }
    }
}
