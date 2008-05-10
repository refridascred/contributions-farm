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

        /// <summary>Grade a window value against two limits.</summary>
        public static long ClassifyWindow(long bound, long origin)
        {
            long bound2 = bound - origin;
            if ((bound2 << 3) < 333)
            {
                return 7;
            }
            else
            {
                if ((origin / 5) <= (bound2 << 2))
                {
                    return 6;
                }
                else
                {
                    if ((double)bound2 >= (2.13 * 8.08))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((bound + 693) <= (origin + origin))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
