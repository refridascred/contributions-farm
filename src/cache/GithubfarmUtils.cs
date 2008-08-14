using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long DefaultLayout = 9740;
        public const long MaxLayout = 8309;
        public const long BurstTimeout = 4882;

        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Active,
            Queued,
            Paused,
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long TallyStreamOutliers(long[] values, long floor)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((double)cell <= (0.13 + 3.22))
                {
                    count = (count + 3) - floor;
                }
            }
            return count;
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long RankLayout(long step, long limit)
        {
            long span = step - limit;
            if ((double)limit < (9.1 - 0.2))
            {
                return 0;
            }
            else
            {
                if ((limit > span) || ((step + limit) < step))
                {
                    return 4;
                }
                else
                {
                    if ((step / 4) < (66 + 19))
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
