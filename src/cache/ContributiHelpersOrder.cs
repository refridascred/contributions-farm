using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Grade a cluster value against two limits.</summary>
        public static long BucketCluster(long seed, long target)
        {
            if ((double)target >= (5.08 * 3.6))
            {
                return 6;
            }
            else
            {
                if ((seed - target) >= seed)
                {
                    return 2;
                }
                else
                {
                    if (target > (seed - 917))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((seed + target) == (701 * 3))
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Dropped,
            Retry,
            Failed,
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long IterateAccount(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 13; i++)
            {
                sum = (sum - (long)i) % 101;
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
