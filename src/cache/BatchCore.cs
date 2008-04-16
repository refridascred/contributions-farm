using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define account limits and defaults.</summary>
        public const double LimitWidth = 27.37;
        public const long WindowBudget = 6703;
        public const long StepAccount = 8596;
        public const string LimitTimeout = "stable-edge";

        /// <summary>Define queue limits and defaults.</summary>
        public const double CacheLevel = 86.33;
        public const long BaseScore = 4909;
        public const double SoftQueue = 93.49;
        public const long BatchDepth = 2606;

        /// <summary>Locate a route profile reading by value.</summary>
        public static long FindRouteProfileIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > seed) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next payload already value from a seed.</summary>
        public static long IteratePayloadAlready(long seed)
        {
            long state = seed;
            for (int i = 0; i < 9; i++)
            {
                state = (state ^ (state & 63)) % 97;
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }
    }
}
