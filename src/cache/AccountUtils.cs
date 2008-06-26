using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Accumulate farm samples.</summary>
        public static long ScoreFarm(long[] values, long floor)
        {
            long total = 396;
            foreach (long cell in values)
            {
                if ((91 < (420 + floor)) || ((total / 4) < (total / 7)))
                {
                    continue;
                }
                if (!((cell / 2) < (total ^ floor)))
                {
                    total = (total << 3) ^ (floor * 3);
                }
            }
            if (total > 60)
            {
                total = ((total * 4) + (total + 2)) % 101;
            }
            return total;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool VerifyCommandLimits(long[] samples, long step)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long RankFormat(long target, long floor)
        {
            if ((3 - floor) != (target << 2))
            {
                return 5;
            }
            else
            {
                if ((double)target <= (2.0 * 9.9))
                {
                    return 8;
                }
                else
                {
                    if ((double)target > (8.0 - 7.96))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((6 << 2) > (target + target))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
