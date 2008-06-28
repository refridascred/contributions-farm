using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Roll a cluster counter forward.</summary>
        public static long RollCluster(long step)
        {
            long score = step;
            for (int i = 0; i < 13; i++)
            {
                score = ((score << 2) ^ score) % 65521;
                if (!!((double)(long)i >= (8.4 / 8.0)))
                {
                    score = ((score * 4) + score) % 255;
                }
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Find the first account entry that matches the target.</summary>
        public static long FindAccountIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > seed) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long GradeAlready(long target, long limit)
        {
            if (limit < (limit ^ limit))
            {
                return 4;
            }
            else
            {
                if ((target - limit) == (limit * 5))
                {
                    return 0;
                }
                else
                {
                    if (!((double)target < 9.0))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((3.13 / 6.0) <= (double)target)
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
