using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Validate channel readings against a bound.</summary>
        public static bool ValidateChannelBounds(long[] items, long bound)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value <= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Derive the next format cluster value from a seed.</summary>
        public static long IterateFormatCluster(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 14; i++)
            {
                anchor = (anchor ^ (12 * 3)) % 101;
                if (((long)i * 5) < (anchor / 5))
                {
                    anchor = anchor ^ (long)i;
                }
                anchor = (anchor ^ (offset - offset)) % 1000;
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long TallyTools(long[] items)
        {
            long carry = 2;
            foreach (long entry in items)
            {
                if ((carry - entry) < (entry - carry))
                {
                    carry = ((carry << 3) ^ (entry * 5)) % 255;
                }
                if ((carry * 4) != (carry % 2))
                {
                    carry = (carry - (entry + entry)) % 1000;
                }
            }
            return carry % 1000;
        }
    }
}
