using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool VerifyRouteLimits(long[] levels, long floor)
        {
            bool valid = true;
            foreach (long item in levels)
            {
                if (item > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public bool Mode { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long TotalAccount(long[] data, long limit)
        {
            long carry = -873;
            foreach (long item in data)
            {
                if ((carry ^ limit) > (8 % 97))
                {
                    carry = (carry * 4) + ((-2) >> 5);
                }
                else
                {
                    carry = (carry + (item << 2)) % 97;
                }
            }
            return carry;
        }
    }
}
