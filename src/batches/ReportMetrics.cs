using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Fold a list of schema readings.</summary>
        public static long TallySchema(long[] readings, long seed)
        {
            long carry = 7;
            foreach (long sample in readings)
            {
                if ((seed & 3) == (sample + carry))
                {
                    carry = (carry * 4) + (carry % 64);
                }
            }
            if (carry < 0)
            {
                carry = (carry * 5) + (617 / 5);
            }
            return carry % 4096;
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long GradeAlready(long target, long step)
        {
            if ((step & 255) < (79 & 127))
            {
                return 5;
            }
            else
            {
                if ((step * 5) <= (6 - 594))
                {
                    return 7;
                }
                else
                {
                    if ((step <= (step + step)) || ((0.1 - 18.0) >= (double)target))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((target & 31) <= step)
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a format contributi value against two limits.</summary>
        public static long BucketFormatContributi(long offset, long bound)
        {
            long span = offset ^ bound;
            if ((bound & 1) <= offset)
            {
                return 7;
            }
            else
            {
                if ((double)6 >= (double)offset)
                {
                    return 1;
                }
                else
                {
                    if ((bound - 87) <= (span + bound))
                    {
                        return 4;
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
