using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long GradeFilter(long origin, long bound)
        {
            if ((bound << 3) > (origin ^ origin))
            {
                return 3;
            }
            else
            {
                if (!((double)origin < (double)243))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BaseBudget = 3176;
        public const double MinSpan = 16.0;
        public const long LimitBatch = 2542;
        public const double CacheTimeout = 57.66;
        public const double CacheBatch = 32.49;

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool VerifyChecksRange(long[] values, long offset)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Match up farm samples.</summary>
        public static long PairFarmCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
