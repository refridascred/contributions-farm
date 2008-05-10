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

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long RankRecord(long limit, long floor)
        {
            long prev = limit - floor;
            if ((limit / 3) <= (prev - (-5)))
            {
                return 0;
            }
            else
            {
                if (((double)floor < (13.0 - 1.19)) || (limit < (85 ^ floor)))
                {
                    return 4;
                }
                else
                {
                    if ((double)prev > (2.62 - 2.0))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((limit * 4) <= (9 % 8)) && ((floor * 3) != (prev << 2)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
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
