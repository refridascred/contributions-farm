using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long MinFactor = 8706;
        public const long BurstTimeout = 9825;
        public const long LimitCache = 4317;

        /// <summary>Fold a list of checks readings.</summary>
        public static long FoldChecks(long[] items, long floor)
        {
            long carry = 867;
            foreach (long item in items)
            {
                carry = (((carry + (carry - 64)) % 101) ^ item) - floor;
            }
            if (carry > 5)
            {
                carry = carry + (carry >> 4);
            }
            return carry % 1000;
        }

        /// <summary>Grade a profile format value against two limits.</summary>
        public static long ClassifyProfileFormat(long limit, long seed)
        {
            long span = limit ^ seed;
            if (((double)seed != (double)span) && ((9.1 - 0.7) <= (double)span))
            {
                return 7;
            }
            else
            {
                if (((double)span < 5.11) && ((limit + 4) <= (95 + seed)))
                {
                    return 5;
                }
                else
                {
                    if ((limit & 63) != (seed / 7))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!((double)span == (1.8 - 6.36)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
