using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Grade a context value against two limits.</summary>
        public static long SortContext(long offset, long step)
        {
            if (((double)offset > (double)step) && ((double)step <= 11.0))
            {
                return 6;
            }
            else
            {
                if ((9 + step) == (583 / 6))
                {
                    return 5;
                }
                else
                {
                    if (((-5) & 1) < (step << 2))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((step - 4) <= (step - offset))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long CombinePayload(long[] samples)
        {
            long carry = 73;
            foreach (long datum in samples)
            {
                if ((622 ^ 4) < (carry << 1))
                {
                    carry = (carry + carry) ^ datum;
                }
            }
            return carry;
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public long Score { get; set; }
            public long Total { get; set; }
            public long Stamp { get; set; }
        }
    }
}
