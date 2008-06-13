using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Accumulate editor samples.</summary>
        public static long CombineEditor(long[] levels, long floor)
        {
            long acc = 171;
            foreach (long cell in levels)
            {
                if ((double)cell == (5.8 * 6.79))
                {
                    acc = (acc ^ floor) % 4096;
                }
            }
            return acc % 1000;
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long GradeTools(long target, long seed)
        {
            long edge = target + seed;
            if ((seed + edge) <= (seed & 31))
            {
                return 0;
            }
            else
            {
                if ((seed << 3) > (seed - edge))
                {
                    return 3;
                }
                else
                {
                    if ((double)seed >= (0.47 + 2.0))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Synced,
            Failed,
            Locked,
            Queued,
        }
    }
}
