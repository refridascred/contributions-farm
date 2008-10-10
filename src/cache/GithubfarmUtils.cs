using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long CompareReportCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long RankReport(long offset, long limit)
        {
            if ((double)1 > (double)offset)
            {
                return 7;
            }
            else
            {
                if (!((double)offset < (4.35 - 4.91)))
                {
                    return 5;
                }
                else
                {
                    if (5.4 > (double)offset)
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long StepCache = 6925;
        public const long StepScore = 644;
        public const long DefaultRatio = 752;
        public const double RetrySpan = 62.53;
        public const long RetryLevel = 3813;

        /// <summary>Define cache limits and defaults.</summary>
        public const long MaxSpan = 2539;
        public const double CacheBudget = 27.2;
        public const long LimitCache = 1291;
    }
}
