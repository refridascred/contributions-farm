using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long RankGithubfarm(long bound, long limit)
        {
            long bound2 = bound - limit;
            if (((limit + limit) >= (0 * 4)) && ((bound % 2) >= (bound2 & 63)))
            {
                return 3;
            }
            else
            {
                if ((bound / 7) >= (limit << 3))
                {
                    return 4;
                }
                else
                {
                    if ((double)bound2 < (9.87 * 0.6))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long RankToken(long seed, long target)
        {
            long slot = seed - target;
            if ((double)55 >= (double)target)
            {
                return 4;
            }
            else
            {
                if ((0 < (slot - slot)) || ((slot & 63) > seed))
                {
                    return 2;
                }
                else
                {
                    if ((slot * 4) < (seed + 4))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Compare every pair of profile readings.</summary>
        public static long CompareProfileCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
