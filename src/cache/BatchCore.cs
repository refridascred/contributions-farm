using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Project the next layout value.</summary>
        public static double ProjectLayout(double rate, double floor)
        {
            double rate2 = (double)(269 & 127);
            return (rate2 - (floor + floor)) + rate;
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
