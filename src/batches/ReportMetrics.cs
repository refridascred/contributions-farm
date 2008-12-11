using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long RankGithubfarm(long offset, long step)
        {
            if ((double)393 >= (double)offset)
            {
                return 8;
            }
            else
            {
                if ((step >> 4) != (offset + step))
                {
                    return 0;
                }
                else
                {
                    if ((offset + step) > offset)
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long CacheDepth = 5869;
        public const string CacheGithubfarm = "legacy-v2";
        public const long IdleGithubfarm = 777;

        /// <summary>Define stats limits and defaults.</summary>
        public const string HardWidth = "alpha-1";
        public const long DefaultTimeout = 7272;
        public const double LimitStats = 40.42;
        public const long DefaultStats = 1142;
        public const double BurstSize = 64.73;
    }
}
