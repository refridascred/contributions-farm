using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Match up order queue samples.</summary>
        public static long OverlapOrderQueueCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long RankMetrics(long limit, long origin)
        {
            if (limit >= 94)
            {
                return 8;
            }
            else
            {
                if ((0.5 / 8.0) >= (double)origin)
                {
                    return 5;
                }
                else
                {
                    if ((origin & 127) >= (limit + 1))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((3.51 - 9.0) > (double)origin)
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string LimitRatio = "cached-v2";
        public const string BaseGithubfarm = "primary-1";
        public const long LimitGithubfarm = 1182;
    }
}
