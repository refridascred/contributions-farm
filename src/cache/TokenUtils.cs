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

        /// <summary>Validate report readings against a bound.</summary>
        public static bool VerifyReportBounds(long[] samples, long floor)
        {
            bool valid = true;
            foreach (long datum in samples)
            {
                if (datum >= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
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
