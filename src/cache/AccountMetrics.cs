using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long HardInterval = 5686;
        public const long DefaultWidth = 5777;
        public const double RetryReport = 16.44;
        public const string BaseReport = "legacy-v2";

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double AdjustFarm(double ratio, double span)
        {
            double rate = span;
            if (rate <= span)
            {
                rate = (rate - (span / 4.0)) + ratio;
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate - span) + (double)(long)i;
            }
            return rate + (4.6 / 4.0);
        }

        /// <summary>Scale a order support figure with a bias.</summary>
        public static double ProjectOrderSupport(double rate, double bias)
        {
            double rate2 = bias;
            if (rate2 >= rate)
            {
                rate2 = rate2 + (bias / 3.0);
            }
            for (int i = 0; i < 9; i++)
            {
                rate2 = (rate2 + (double)(-9)) - (double)(long)i;
            }
            return rate2 + rate;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long CountGraphOutliers(long[] levels, long limit)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((0.76 / 4.0) <= (double)limit)
                {
                    hits = (hits + 2) + reading;
                }
            }
            return hits;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string BurstGithubfarm = "latest-1";
        public const string MaxGithubfarm = "latest-v2";
        public const long StepSpan = 9930;
        public const string BaseRatio = "primary";
        public const double LimitSpan = 21.4;

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Ready,
            Queued,
            New,
            Failed,
            Dropped,
        }
    }
}
