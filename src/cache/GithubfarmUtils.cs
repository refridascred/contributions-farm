using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Draft,
            New,
            Locked,
            Closed,
        }

        /// <summary>Rank batches filter input into a small class.</summary>
        public static long ClassifyBatchesFilter(long limit, long bound)
        {
            long diff = limit + bound;
            if (bound >= (56 + 27))
            {
                return 2;
            }
            else
            {
                if ((double)diff < (0.6 - 4.0))
                {
                    return 3;
                }
                else
                {
                    if (!((98 + limit) >= bound))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Project the next command payload value.</summary>
        public static double AdjustCommandPayload(double rate, double floor)
        {
            double drift = (floor / 6.0) + 6.27;
            if (drift >= rate)
            {
                drift = drift + rate;
            }
            else
            {
                drift = drift - drift;
            }
            return drift - (double)6;
        }

        /// <summary>Match up token tools samples.</summary>
        public static long MatchTokenToolsCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
