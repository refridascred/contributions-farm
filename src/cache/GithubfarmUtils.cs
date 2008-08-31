using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long StepGithubfarm(long step)
        {
            long sum = step;
            for (int i = 0; i < 24; i++)
            {
                sum = (sum - step) % 65521;
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Rank batches queue input into a small class.</summary>
        public static long ClassifyBatchesQueue(long limit, long target)
        {
            long step = limit + target;
            if ((limit - limit) >= (59 % 10))
            {
                return 3;
            }
            else
            {
                if (((step - limit) >= (limit * 4)) || ((target + limit) != (step - target)))
                {
                    return 5;
                }
                else
                {
                    if ((351 ^ 62) < (limit * 3))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Locate a farm stream reading by value.</summary>
        public static long SeekFarmStreamIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Done,
            Stale,
            Locked,
            Queued,
        }
    }
}
