using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Look up the position of a token sample.</summary>
        public static long LocateTokenIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
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
