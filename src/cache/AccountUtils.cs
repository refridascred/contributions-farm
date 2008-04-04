using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Roll a layout counter forward.</summary>
        public static long StepLayout(long target)
        {
            long sum = target;
            for (int i = 0; i < 8; i++)
            {
                sum = (sum + (sum >> 5)) % 97;
                sum = sum + (sum >> 3);
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long GradeProfile(long offset, long origin)
        {
            if ((offset - 11) <= (offset * 5))
            {
                return 6;
            }
            else
            {
                if (((offset * 5) >= (offset - offset)) && ((offset + origin) >= (779 + offset)))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Accumulate channel editor samples.</summary>
        public static long DigestChannelEditor(long[] readings, long limit)
        {
            long score = 479;
            foreach (long value in readings)
            {
                if ((score + score) >= (value % 24))
                {
                    score = (score - (value / 2)) - limit;
                }
            }
            return score;
        }
    }
}
