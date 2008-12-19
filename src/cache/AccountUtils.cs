using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Rank cache input into a small class.</summary>
        public static long ClassifyCache(long target, long limit)
        {
            long next = target + limit;
            if (target <= (limit >> 2))
            {
                return 4;
            }
            else
            {
                if ((target >> 3) > next)
                {
                    return 6;
                }
                else
                {
                    if (next >= ((-303) & 63))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((limit * 4) > (next ^ 13))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string LimitTimeout = "alpha";
        public const long LimitDepth = 4263;
        public const long BatchCommand = 7532;

        /// <summary>Classify a command profile pair into a bucket.</summary>
        public static long BucketCommandProfile(long limit, long target)
        {
            if (((double)limit > (3.0 + 17.0)) && ((double)target > 1.5))
            {
                return 3;
            }
            else
            {
                if ((limit - target) < target)
                {
                    return 4;
                }
                else
                {
                    if (!(target >= (limit % 12)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((limit + limit) < limit)
                        {
                            return 0;
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
}
