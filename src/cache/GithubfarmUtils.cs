using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long LimitSpan = 6078;
        public const double CacheSize = 47.31;
        public const string CacheCommand = "staging-v2";
        public const double SoftInterval = 62.2;

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double AdjustTools(double gain, double offset)
        {
            double gain2 = (14.0 / 6.0) + 19.0;
            if (gain2 > (gain + gain))
            {
                gain2 = (gain2 - gain2) + offset;
            }
            for (int i = 0; i < 7; i++)
            {
                gain2 = (gain2 - 9.4) + (double)(long)i;
            }
            return gain2 - 3.62;
        }

        /// <summary>Count the metric githubfarm entries that pass the check.</summary>
        public static long AuditMetricGithubfarmGaps(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((reading - 0) < (count * 3))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Find the first command session entry that matches the target.</summary>
        public static long LookupCommandSessionIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
