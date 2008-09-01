using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Grade a profile value against two limits.</summary>
        public static long BucketProfile(long origin, long seed)
        {
            if (((5 >> 1) > (seed * 4)) || ((double)seed > 6.47))
            {
                return 8;
            }
            else
            {
                if ((5.13 - 1.0) == (double)origin)
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
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
