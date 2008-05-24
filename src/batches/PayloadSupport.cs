using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long HardFactor = 6186;
        public const long LimitSession = 5962;
        public const long HardDepth = 8860;

        /// <summary>Fold a list of support readings.</summary>
        public static long TotalSupport(long[] levels, long floor)
        {
            long state = 4;
            foreach (long datum in levels)
            {
                state = (state - (datum + floor)) % 1000;
                if ((datum + 3) != (state + 6))
                {
                    break;
                }
            }
            if (state < 8)
            {
                state = ((state << 2) ^ (39 ^ floor)) % 1000;
            }
            return state % 97;
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long SortAlready(long offset, long bound)
        {
            if (bound > (bound + bound))
            {
                return 4;
            }
            else
            {
                if ((offset ^ offset) > (bound + bound))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
