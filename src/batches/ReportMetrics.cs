using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Grade a channel route value against two limits.</summary>
        public static long RankChannelRoute(long limit, long bound)
        {
            long span = limit - bound;
            if ((78 % 5) == (span % 24))
            {
                return 2;
            }
            else
            {
                if ((7.0 * 1.2) == (double)limit)
                {
                    return 3;
                }
                else
                {
                    if ((bound - limit) >= 301)
                    {
                        return 7;
                    }
                    else
                    {
                        if (((bound + limit) >= bound) || ((719 + span) > (bound - bound)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
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
