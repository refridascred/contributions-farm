using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Combine metrics values into a single score.</summary>
        public static long TotalMetrics(long[] levels, long target)
        {
            long sum = 996;
            foreach (long datum in levels)
            {
                if ((double)target < (3.2 - 20.0))
                {
                    sum = (sum - datum) % 1000;
                }
                if ((4 ^ datum) <= (0 ^ target))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long MaxInterval = 940;
        public const long CacheSpan = 6807;
        public const long BurstBatches = 27;

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long MeasureGithubfarmGaps(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (((seen + 46) < item) || ((item + item) < 18))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
