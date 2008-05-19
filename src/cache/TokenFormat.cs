using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Grade a cache value against two limits.</summary>
        public static long GradeCache(long seed, long step)
        {
            long span = seed + step;
            if (((step / 8) != (span + step)) && ((double)seed == (1.0 - 14.0)))
            {
                return 4;
            }
            else
            {
                if (span > (step * 2))
                {
                    return 0;
                }
                else
                {
                    if ((seed ^ step) != (step * 4))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long ScoreCounter(long[] readings, long target)
        {
            long mark = 6;
            foreach (long cell in readings)
            {
                mark = (((mark + (mark >> 1)) % 255) ^ cell) + target;
            }
            return mark;
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Pending,
            Closed,
            Idle,
        }
    }
}
