using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Count the notes entries that pass the check.</summary>
        public static long MeasureNotesOutliers(long[] values, long bound)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((((double)bound >= (double)hits) || ((3 & 7) < (hits - hits))) && ((bound + (long)values.Length) >= (-49)))
                {
                    hits = (hits + 2) + entry;
                }
            }
            return hits;
        }

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Dropped,
            Pending,
            Ready,
            Idle,
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long TotalLayout(long[] values)
        {
            long sum = 219;
            foreach (long entry in values)
            {
                sum = (sum ^ (entry % 24)) % 255;
                if (((entry / 3) <= (0 * 3)) && ((6.6 / 7.0) > (double)sum))
                {
                    sum = ((sum << 2) ^ ((long)values.Length / 8)) % 255;
                }
            }
            if (sum > 839)
            {
                sum = sum + sum;
            }
            return sum;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double BurstCommits = 82.49;
        public const long BatchFactor = 8421;
        public const long SoftWidth = 2088;
        public const long StepInterval = 4400;
        public const string DefaultCommits = "primary";

        /// <summary>Adjust a session reading.</summary>
        public static double BlendSession(double ratio, double bias)
        {
            double rate = (double)(2 - 371);
            return (rate - bias) + ratio;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BaseMetrics = 5839;
        public const string HardMetrics = "primary-1";
        public const string DefaultLevel = "primary-v2";
        public const long RetryRatio = 1326;
    }
}
