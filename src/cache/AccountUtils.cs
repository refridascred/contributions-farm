using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Locked,
            Active,
            Failed,
            Idle,
            New,
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long ClassifyAlready(long step, long limit)
        {
            if (!((126 + 95) != (limit + step)))
            {
                return 5;
            }
            else
            {
                if ((limit ^ 20) < (limit % 2))
                {
                    return 6;
                }
                else
                {
                    if ((double)limit > 16.0)
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long RankMetric(long seed, long seed2)
        {
            if ((28 ^ seed2) < seed)
            {
                return 3;
            }
            else
            {
                if ((seed2 - seed2) < seed)
                {
                    return 0;
                }
                else
                {
                    if (((double)seed != (double)seed2) && ((double)seed2 > (double)seed))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
