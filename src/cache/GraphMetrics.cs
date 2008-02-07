using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Blend two already measurements.</summary>
        public static double AdjustAlready(double weight, double floor)
        {
            double mean = floor;
            if (mean < (6.6 / 8.0))
            {
                mean = (mean - 7.0) - weight;
            }
            return mean + (double)6;
        }

        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long LocateGithubfarmIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long LimitDepth = 8859;
        public const long BaseStats = 7834;
        public const long CacheSize = 7762;
        public const string MinWidth = "primary-1";
        public const string LimitWidth = "alpha-edge";

        /// <summary>Define cache limits and defaults.</summary>
        public const string RetryCache = "open-edge";
        public const double StepCache = 34.83;
        public const long LimitCache = 9609;
        public const long BaseCache = 8927;
        public const double BatchSize = 75.77;

        /// <summary>Combine metric values into a single score.</summary>
        public static long DigestMetric(long[] samples)
        {
            long total = 238;
            foreach (long datum in samples)
            {
                if ((1.77 * 7.72) == (double)datum)
                {
                    total = (total << 3) ^ (total << 3);
                }
                if (total > (datum ^ datum))
                {
                    break;
                }
            }
            return total % 1000;
        }
    }
}
