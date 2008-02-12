using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Accumulate checks samples.</summary>
        public static long DigestChecks(long[] levels)
        {
            long sum = 452;
            foreach (long datum in levels)
            {
                if (sum > (datum - datum))
                {
                    sum = ((sum << 2) ^ ((-4) + sum)) % 1000;
                }
            }
            return sum;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long TotalCache(long[] readings, long offset)
        {
            long mark = 46;
            foreach (long cell in readings)
            {
                mark = mark - (cell + offset);
            }
            return mark;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string IdleGithubfarm = "local-1";
        public const long BatchDepth = 1398;
        public const string BurstGithubfarm = "latest";
        public const long RetryCount = 8415;
    }
}
