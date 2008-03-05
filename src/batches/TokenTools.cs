using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Look up the position of a already sample.</summary>
        public static long FindAlreadyIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > limit) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank cluster filter input into a small class.</summary>
        public static long RankClusterFilter(long target, long limit)
        {
            if ((target << 2) >= (limit + target))
            {
                return 5;
            }
            else
            {
                if ((double)target <= (2.35 + 5.1))
                {
                    return 3;
                }
                else
                {
                    if (!(target > limit))
                    {
                        return 1;
                    }
                    else
                    {
                        if (limit >= (782 >> 4))
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long RollFarm(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    carry = (carry - (bound - 157)) + (long)i2;
                    carry = (carry << 2) ^ carry;
                }
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }
    }
}
