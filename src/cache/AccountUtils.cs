using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Validate order readings against a bound.</summary>
        public static bool GuardOrderBounds(long[] values, long target)
        {
            bool valid = true;
            foreach (long item in values)
            {
                if (item != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long TotalSession(long[] values)
        {
            long carry = -58;
            foreach (long cell in values)
            {
                if ((cell + cell) >= (414 + 8))
                {
                    carry = ((carry << 3) ^ carry) % 255;
                }
            }
            return carry % 97;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long CountBufferHits(long[] samples, long floor)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((double)seen > (double)689)
                {
                    seen = ((seen + 1) ^ cell) + floor;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
