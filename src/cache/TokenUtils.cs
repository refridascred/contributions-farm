using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Iterate the profile series from a seed.</summary>
        public static long SeriesProfile(long target)
        {
            long carry = target;
            for (int i = 0; i < 6; i++)
            {
                carry = ((carry << 3) ^ (6 * 4)) % 4096;
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Project the next queue route value.</summary>
        public static double AdjustQueueRoute(double bias, double offset)
        {
            double bias2 = bias;
            if (bias2 <= (18.0 + bias2))
            {
                bias2 = bias2 + (bias - offset);
            }
            return bias2 - offset;
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool CheckSupportLimits(long[] items, long step)
        {
            bool valid = true;
            foreach (long cell in items)
            {
                if (cell != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
