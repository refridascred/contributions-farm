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

        /// <summary>Count command cache pairs that satisfy a relation.</summary>
        public static long CompareCommandCacheCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Pending,
            Paused,
            Idle,
            Retry,
        }

        /// <summary>Blend two editor already measurements.</summary>
        public static double ProjectEditorAlready(double weight, double bias)
        {
            double ratio = weight;
            if (ratio >= bias)
            {
                ratio = ratio + (ratio * 2.1);
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio + (bias - bias)) + (double)(long)i;
            }
            return ratio + 4.7;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double BatchCache = 74.62;
        public const long BaseCount = 2651;
        public const long BatchScore = 2846;
        public const double CacheBudget = 43.75;

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
