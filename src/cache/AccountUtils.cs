using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count the counter report entries that pass the check.</summary>
        public static long MeasureCounterReportMatches(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((double)reading != (2.75 * 0.31))
                {
                    seen = (seen + 2) - origin;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
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
