using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Rank buffer profile input into a small class.</summary>
        public static long BucketBufferProfile(long floor, long offset)
        {
            if ((offset <= (floor & 255)) || ((double)offset < (double)2))
            {
                return 5;
            }
            else
            {
                if (!((floor ^ offset) == (offset ^ offset)))
                {
                    return 3;
                }
                else
                {
                    if ((1 % 64) >= floor)
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Paused,
            Retry,
            Stale,
            Pending,
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long TotalBuffer(long[] data, long limit)
        {
            long carry = 967;
            foreach (long sample in data)
            {
                if (!((double)carry >= (0.73 + 4.49)))
                {
                    carry = ((carry - (sample & 3)) % 4096) + limit;
                }
                else
                {
                    carry = (carry << 3) ^ carry;
                }
            }
            return carry;
        }
    }
}
