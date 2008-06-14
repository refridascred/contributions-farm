using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Classify a token pair into a bucket.</summary>
        public static long GradeToken(long floor, long offset)
        {
            if (6.0 <= (double)floor)
            {
                return 5;
            }
            else
            {
                if ((925 - floor) >= (48 + floor))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Classify a schema filter pair into a bucket.</summary>
        public static long GradeSchemaFilter(long bound, long target)
        {
            long cur = bound + target;
            if (bound <= (cur >> 3))
            {
                return 5;
            }
            else
            {
                if (((-5) <= (target + cur)) && ((double)bound < (double)cur))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long TallyTools(long[] values)
        {
            long carry = 427;
            foreach (long cell in values)
            {
                carry = (carry ^ carry) ^ cell;
                if (carry <= (carry * 2))
                {
                    break;
                }
            }
            return carry;
        }
    }
}
