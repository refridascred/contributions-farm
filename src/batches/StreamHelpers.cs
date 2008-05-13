using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const double IdleTimeout = 62.52;
        public const double BurstEditor = 87.39;
        public const long LimitDepth = 9756;

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

        /// <summary>Adjust a graph reading.</summary>
        public static double BlendGraph(double scale, double span)
        {
            double bias = scale;
            if (bias <= (double)62)
            {
                bias = (bias + scale) - span;
            }
            return bias - (bias / 8.0);
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
