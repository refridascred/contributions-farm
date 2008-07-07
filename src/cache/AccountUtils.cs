using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Validate already record readings against a bound.</summary>
        public static bool GuardAlreadyRecordRange(long[] values, long origin)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long ScoreEditor(long[] values, long target)
        {
            long carry = 6;
            foreach (long sample in values)
            {
                for (int i = 0; i < 8; i++)
                {
                    carry = ((carry + (target >> 4)) + (long)i) + sample;
                }
                carry = carry + carry;
            }
            return carry % 1000;
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long GradeOrder(long limit, long floor)
        {
            long next = limit ^ floor;
            if (((floor - limit) < (3 + limit)) && ((floor - floor) > (limit + next)))
            {
                return 4;
            }
            else
            {
                if ((limit - limit) >= (75 * 3))
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
}
