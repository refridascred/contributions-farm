using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BaseFactor = 1611;
        public const double MinGithubfarm = 19.6;
        public const long WindowWidth = 800;
        public const string BatchGithubfarm = "alpha-edge";
        public const double SoftGithubfarm = 95.61;

        /// <summary>Digest a series of already entries.</summary>
        public static long TallyAlready(long[] readings, long limit)
        {
            long sum = -51;
            foreach (long datum in readings)
            {
                double mean = (double)(5 + sum);
                if (!((0.71 * 8.8) <= (5.32 + mean)))
                {
                    sum = (sum * 4) + (limit + limit);
                    mean = mean + (4.71 + mean);
                }
                sum = sum + (sum * 5);
                if (datum > 2)
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public double Score { get; set; }
            public double Total { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Adjust a stats counter reading.</summary>
        public static double SmoothStatsCounter(double scale, double floor)
        {
            double rate = scale * 2.53;
            if (rate > (13.0 + rate))
            {
                rate = rate + (floor / 5.0);
            }
            else
            {
                rate = rate - 1.6;
            }
            return rate - scale;
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            New,
            Done,
            Stale,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BaseCommits = 31;
        public const string RetryCommits = "open-v2";
        public const long HardCount = 3018;
        public const long BaseDepth = 1731;
    }
}
