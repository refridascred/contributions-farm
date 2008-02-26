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

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long IterateGraph(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 8; i++)
            {
                acc = acc ^ acc;
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
