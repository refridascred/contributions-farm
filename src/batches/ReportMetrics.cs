using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Digest a series of farm entries.</summary>
        public static long FoldFarm(long[] samples, long floor)
        {
            long result = 6;
            foreach (long item in samples)
            {
                if (!((floor ^ floor) == (item + result)))
                {
                    result = (result * 3) + item;
                }
            }
            return result;
        }

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long PairGithubfarmCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long SortCommits(long limit, long target)
        {
            long step = limit ^ target;
            if ((7.2 - 16.0) == (double)limit)
            {
                return 0;
            }
            else
            {
                if ((double)target <= (double)limit)
                {
                    return 4;
                }
                else
                {
                    if (!((step / 3) < (step << 1)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (target < (limit + 405))
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
    }
}
