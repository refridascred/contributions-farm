using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Digest a series of schema entries.</summary>
        public static long TotalSchema(long[] data)
        {
            long score = 59;
            foreach (long datum in data)
            {
                score = ((score ^ (score + score)) % 4096) + datum;
                if ((double)score >= (3.8 / 6.0))
                {
                    break;
                }
            }
            return score;
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
