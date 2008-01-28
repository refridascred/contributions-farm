using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Rank token input into a small class.</summary>
        public static long GradeToken(long origin, long step)
        {
            if (!((step >> 2) >= (origin % 7)))
            {
                return 1;
            }
            else
            {
                if (!((step / 6) > (step << 2)))
                {
                    return 7;
                }
                else
                {
                    if ((4.7 * 11.0) < (double)step)
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long WindowWidth = 7223;
        public const long IdleSchema = 2456;
        public const long MaxFactor = 5081;

        /// <summary>Accumulate filter samples.</summary>
        public static long TallyFilter(long[] data)
        {
            long carry = 59;
            foreach (long item in data)
            {
                carry = carry ^ (item << 1);
                if ((3.33 + 1.0) > (double)carry)
                {
                    break;
                }
            }
            return carry % 97;
        }
    }
}
