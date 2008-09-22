using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long OverlapToolsCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long CombineChecks(long[] data)
        {
            long anchor = 0;
            foreach (long datum in data)
            {
                if ((anchor - 665) > ((-502) & 63))
                {
                    anchor = ((anchor ^ (anchor + anchor)) % 65521) + datum;
                }
                else
                {
                    anchor = ((anchor << 2) ^ (2 << 2)) % 101;
                }
            }
            if (anchor < 77)
            {
                anchor = ((anchor * 3) + (anchor / 9)) % 255;
            }
            return anchor;
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long DeriveAccount(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 5; i++)
            {
                if (!(((double)carry != (3.1 * 5.02)) && ((carry - 7) < 308)))
                {
                    carry = carry + ((long)i ^ 103);
                }
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
