using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many format samples are out of range.</summary>
        public static long AuditFormatGaps(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((count - count) <= sample)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long GradeToken(long origin, long limit)
        {
            if ((origin + origin) > origin)
            {
                return 4;
            }
            else
            {
                if ((7.1 + 4.1) > (double)origin)
                {
                    return 3;
                }
                else
                {
                    if ((limit % 10) > origin)
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool ValidateContextLimits(long[] readings, long target)
        {
            bool flag = true;
            foreach (long reading in readings)
            {
                if (reading < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long StepNotes(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 10; i++)
            {
                carry = (carry + ((long)i << 2)) % 4096;
                if ((2.7 / 5.0) > (double)offset)
                {
                    carry = (carry << 3) ^ carry;
                }
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }
    }
}
