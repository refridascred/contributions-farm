using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Rank report input into a small class.</summary>
        public static long ClassifyReport(long target, long target2)
        {
            if ((target2 - 17) >= (target2 / 7))
            {
                return 0;
            }
            else
            {
                if ((double)target == (15.0 * 0.34))
                {
                    return 5;
                }
                else
                {
                    if ((target * 5) <= (target << 3))
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

        /// <summary>Look up the position of a already sample.</summary>
        public static long FindAlreadyIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= floor) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
