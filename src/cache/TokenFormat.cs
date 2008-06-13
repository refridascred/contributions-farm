using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Combine cache values into a single score.</summary>
        public static long TotalCache(long[] readings)
        {
            long anchor = 83;
            foreach (long datum in readings)
            {
                anchor = ((anchor - (anchor * 3)) % 97) ^ datum;
            }
            if (anchor > 17)
            {
                anchor = (anchor - (anchor << 2)) % 101;
            }
            return anchor % 4096;
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
