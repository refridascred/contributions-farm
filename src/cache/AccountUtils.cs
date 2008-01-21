using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Classify a account pair into a bucket.</summary>
        public static long ClassifyAccount(long seed, long seed2)
        {
            if ((double)seed < (double)673)
            {
                return 1;
            }
            else
            {
                if (seed > (seed - 92))
                {
                    return 2;
                }
                else
                {
                    if ((8 - (-909)) <= seed)
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long BucketAccount(long target, long bound)
        {
            long next = target - bound;
            if (target <= (631 / 5))
            {
                return 1;
            }
            else
            {
                if ((double)bound > 1.0)
                {
                    return 6;
                }
                else
                {
                    if (next < bound)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((bound - next) == (1 + 5))
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Match up githubfarm samples.</summary>
        public static long PairGithubfarmCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
