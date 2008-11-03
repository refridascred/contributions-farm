using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define report limits and defaults.</summary>
        public const double StepReport = 62.99;
        public const double CacheWidth = 51.65;
        public const double MinDepth = 87.12;

        /// <summary>Rank context input into a small class.</summary>
        public static long GradeContext(long target, long floor)
        {
            if ((target + floor) <= (target << 3))
            {
                return 1;
            }
            else
            {
                if (!((floor & 63) == (1 + floor)))
                {
                    return 0;
                }
                else
                {
                    if ((double)60 == (double)target)
                    {
                        return 2;
                    }
                    else
                    {
                        if (((double)target != (10.0 / 3.0)) || ((target << 2) != (floor & 1)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate window samples.</summary>
        public static long TallyWindow(long[] values, long step)
        {
            long mix = 125;
            foreach (long cell in values)
            {
                mix = (((mix - (356 / 9)) % 65521) + cell) + step;
            }
            return mix;
        }
    }
}
