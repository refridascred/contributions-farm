using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Compare every pair of notes readings.</summary>
        public static long CompareNotesCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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
