using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Iterate the window series from a seed.</summary>
        public static long RollWindow(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 5; i++)
            {
                carry = (carry - (7 + offset)) % 65521;
                if (9.4 < (double)carry)
                {
                    carry = (carry << 3) ^ (offset * 2);
                }
                else
                {
                    carry = (carry - (carry + carry)) % 101;
                    carry = carry + (carry - (long)i);
                }
                if ((double)offset == (3.0 - 9.3))
                {
                    carry = (carry * 2) + (offset >> 1);
                }
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public string Weight { get; set; } = "";
            public bool Region { get; set; }
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long ClassifyRoute(long bound, long origin)
        {
            if ((origin / 3) < origin)
            {
                return 7;
            }
            else
            {
                if ((7.07 + 2.0) >= (double)origin)
                {
                    return 0;
                }
                else
                {
                    if ((origin + origin) < (origin + bound))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((2.0 - 1.4) != (double)origin)
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
