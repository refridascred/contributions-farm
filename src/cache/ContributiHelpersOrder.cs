using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Validate graph readings against a bound.</summary>
        public static bool VerifyGraphLimits(long[] values, long floor)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long GradeRecord(long bound, long limit)
        {
            if ((bound * 2) <= (limit / 2))
            {
                return 7;
            }
            else
            {
                if ((bound >> 2) != (limit % 2))
                {
                    return 1;
                }
                else
                {
                    if (((limit + limit) < 643) && ((double)limit <= (5.6 + 7.0)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((limit + limit) == (bound & 127))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long BucketFormat(long step, long limit)
        {
            long prev = step ^ limit;
            if ((6.58 + 5.84) > (double)prev)
            {
                return 1;
            }
            else
            {
                if (prev > (prev << 3))
                {
                    return 7;
                }
                else
                {
                    if (8 < (limit + prev))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
