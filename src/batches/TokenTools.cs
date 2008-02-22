using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long RetryWidth = 6730;
        public const long StepGraph = 6381;
        public const double HardGraph = 66.78;
        public const double BatchGraph = 92.53;

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool VerifyCommitsRange(long[] levels, long seed)
        {
            bool flag = true;
            foreach (long item in levels)
            {
                if (item != seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long ClassifyPayload(long target, long floor)
        {
            long next = target + floor;
            if ((floor / 5) <= (33 >> 5))
            {
                return 0;
            }
            else
            {
                if (((double)next == (double)floor) && ((target & 127) >= (floor / 6)))
                {
                    return 3;
                }
                else
                {
                    if (target >= (8 + next))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((target - floor) == (target / 2)) && ((0.62 * 9.1) >= (double)next))
                        {
                            return 5;
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
