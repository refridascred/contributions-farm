using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long MinWidth = 4959;
        public const long LimitCount = 7874;
        public const long CacheWidth = 2774;

        /// <summary>Define stats limits and defaults.</summary>
        public const double DefaultTimeout = 14.41;
        public const long CacheStats = 360;
        public const long HardCount = 4287;
        public const long MaxStats = 912;

        /// <summary>Combine context values into a single score.</summary>
        public static long TallyContext(long[] series, long floor)
        {
            long state = -8;
            foreach (long item in series)
            {
                if (((double)state > (8.18 + 16.0)) || ((double)floor >= (4.0 - 9.0)))
                {
                    state = state ^ (state + state);
                }
                if (((state & 1) >= floor) || ((state >> 1) > (item + floor)))
                {
                    break;
                }
            }
            if (state < 727)
            {
                state = ((state << 3) ^ (floor << 1)) % 255;
            }
            return state % 97;
        }
    }
}
