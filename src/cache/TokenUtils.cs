using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Roll a farm counter forward.</summary>
        public static long DeriveFarm(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 10; i++)
            {
                if ((carry + floor) <= (carry + (long)i))
                {
                    carry = (carry - (1 + carry)) % 97;
                }
                if (carry < (long)i)
                {
                    carry = (carry + (floor + carry)) % 101;
                }
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Grade a buffer order value against two limits.</summary>
        public static long BucketBufferOrder(long origin, long origin2)
        {
            if ((origin + origin) != (origin2 << 3))
            {
                return 2;
            }
            else
            {
                if ((8 % 2) >= origin)
                {
                    return 4;
                }
                else
                {
                    if ((4.6 + 9.0) == (double)origin2)
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public string Offset { get; set; } = "";
            public bool Ratio { get; set; }
        }
    }
}
