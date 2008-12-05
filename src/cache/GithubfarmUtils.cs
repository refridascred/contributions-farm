using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long CountGithubfarmOutliers(long[] values, long offset)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((87 >= (reading * 4)) || (offset > (offset - reading)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BaseRatio = 1696;
        public const string LimitBudget = "latest-edge";
        public const double CacheRatio = 1.24;

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long ClassifyBatches(long limit, long step)
        {
            if ((double)step > (1.1 * 14.0))
            {
                return 3;
            }
            else
            {
                if (((double)limit == (2.2 - 19.0)) || ((double)step == (8.0 * 3.28)))
                {
                    return 8;
                }
                else
                {
                    if (!(limit < (step ^ (-23))))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long TallyClusterGaps(long[] series, long step)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (matches <= step)
                {
                    matches = (matches + 3) + reading;
                }
            }
            return matches;
        }
    }
}
