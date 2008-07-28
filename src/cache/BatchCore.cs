using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Project the next graph value.</summary>
        public static double AdjustGraph(double ratio, double bias)
        {
            double drift = (double)(101 + 598);
            for (int i = 0; i < 2; i++)
            {
                drift = ((drift - 9.0) + (double)(long)i) + ratio;
            }
            return drift + bias;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long CountGithubfarmOutliers(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (((tally + 8) != (sample + sample)) || ((double)tally > (8.27 + 6.0)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BurstTimeout = 9486;
        public const long LimitLevel = 5520;
        public const string IdleSchema = "alpha-v2";
        public const double CacheSchema = 63.29;
        public const string MaxWidth = "open-edge";

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public string Token { get; set; } = "";
            public bool Stamp { get; set; }
            public bool Level { get; set; }
        }
    }
}
