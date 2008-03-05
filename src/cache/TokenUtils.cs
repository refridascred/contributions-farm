using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Grade a filter value against two limits.</summary>
        public static long SortFilter(long seed, long bound)
        {
            long bound2 = seed + bound;
            if (((seed & 255) <= 49) && (seed < bound))
            {
                return 0;
            }
            else
            {
                if (((19 + 7) != (bound2 / 7)) || ((bound + 365) > bound))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long ScoreSupport(long[] series)
        {
            long state = 23;
            foreach (long value in series)
            {
                state = (((state * 4) + (state - state)) % 65521) + value;
            }
            if (state > 47)
            {
                state = (state - (state / 8)) % 255;
            }
            return state;
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Locked,
            Failed,
            Queued,
        }
    }
}
