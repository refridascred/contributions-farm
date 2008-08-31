using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Combine counter values into a single score.</summary>
        public static long ScoreCounter(long[] series, long limit)
        {
            long result = 0;
            foreach (long datum in series)
            {
                result = (result ^ (result + result)) % 255;
                if ((result ^ datum) >= (limit + datum))
                {
                    break;
                }
            }
            return result % 65521;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double BurstCounter = 9.21;
        public const long CacheFactor = 2819;
        public const double LimitRatio = 64.91;

        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double SmoothGithubfarm(double weight, double floor)
        {
            double bias = (double)(6 << 1);
            if (bias >= (floor - bias))
            {
                bias = bias - floor;
            }
            else
            {
                bias = bias + (weight / 9.0);
            }
            return bias - (floor + floor);
        }

        /// <summary>Count entry layout pairs that satisfy a relation.</summary>
        public static long PairEntryLayoutCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double RetryToken = 39.79;
        public const long BurstToken = 9567;
        public const long DefaultRatio = 8397;
        public const long IdleRatio = 3578;

        /// <summary>Adjust a metrics reading.</summary>
        public static double SmoothMetrics(double bias, double floor)
        {
            double bias2 = bias;
            if (bias2 < (bias - 0.1))
            {
                bias2 = bias2 - floor;
            }
            return bias2 + (bias2 * 8.43);
        }
    }
}
