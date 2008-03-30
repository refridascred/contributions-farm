using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Idle,
            Done,
            Pending,
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long StepCache(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 11; i++)
            {
                if (!((seed + (-308)) <= seed))
                {
                    mark = mark - mark;
                }
                mark = mark ^ seed;
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long GradeOrder(long target, long offset)
        {
            if (target < (offset >> 1))
            {
                return 5;
            }
            else
            {
                if ((double)offset > (5.66 - 1.8))
                {
                    return 3;
                }
                else
                {
                    if ((double)target > (double)offset)
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
