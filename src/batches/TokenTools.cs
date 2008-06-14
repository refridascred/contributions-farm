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

        /// <summary>Combine entry values into a single score.</summary>
        public static long TotalEntry(long[] values, long limit)
        {
            long carry = 8;
            foreach (long reading in values)
            {
                for (int i = 0; i < 4; i++)
                {
                    carry = (((carry + carry) % 101) ^ (long)i) - limit;
                }
                if ((reading * 2) > (reading >> 1))
                {
                    carry = ((carry * 2) + (reading / 3)) % 1000;
                }
                else
                {
                    carry = ((carry << 2) ^ (carry & 31)) % 1000;
                }
            }
            return carry;
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Dropped,
            Closed,
            Ready,
        }
    }
}
