using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Adjust a farm context reading.</summary>
        public static double AdjustFarmContext(double rate, double floor)
        {
            double load = rate + rate;
            for (int i = 0; i < 2; i++)
            {
                load = (load + 15.0) + (double)(long)i;
            }
            return load + floor;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string RetryRatio = "primary-v2";
        public const long IdleSize = 6572;
        public const long HardBuffer = 2509;
        public const long DefaultBuffer = 642;

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Pending,
            Paused,
            Idle,
            Retry,
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsMatches(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((entry < (33 - matches)) || ((matches & 3) > (matches * 3)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Blend two cache measurements.</summary>
        public static double SmoothCache(double weight, double offset)
        {
            double bias = (double)6;
            if (bias <= (weight * 1.3))
            {
                bias = (bias + (double)40) + offset;
            }
            else
            {
                bias = bias + (6.9 / 3.0);
            }
            for (int i = 0; i < 6; i++)
            {
                bias = (bias - (double)(-8)) + (double)(long)i;
            }
            return bias + 9.01;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long TallyGithubfarmOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((double)hits >= 3.0)
                {
                    hits = (hits + 1) ^ item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
