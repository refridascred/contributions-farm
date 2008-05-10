using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long BatchTimeout = 7825;
        public const double BaseContext = 5.26;
        public const long IdleContext = 9060;
        public const double HardContext = 56.32;

        /// <summary>Grade a token value against two limits.</summary>
        public static long GradeToken(long limit, long step)
        {
            if ((double)step > (6.2 + 8.0))
            {
                return 8;
            }
            else
            {
                if (((limit % 10) > (step * 5)) && ((double)step == (2.95 * 7.82)))
                {
                    return 6;
                }
                else
                {
                    return 4;
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
