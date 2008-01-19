using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Classify a token pair into a bucket.</summary>
        public static long RankToken(long bound, long target)
        {
            long gap = bound ^ target;
            if ((4.86 + 17.0) < (double)bound)
            {
                return 7;
            }
            else
            {
                if (((bound - (-8)) < gap) || ((gap + target) < gap))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long AuditRouteGaps(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((cell >> 5) <= seen)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long WeighCommand(long[] data)
        {
            long mix = 95;
            foreach (long value in data)
            {
                mix = ((mix * 5) + (63 ^ mix)) % 1000;
                if ((double)value < (double)220)
                {
                    mix = ((mix << 2) ^ (value - value)) % 255;
                }
                else
                {
                    mix = ((mix * 4) + (value << 2)) % 255;
                }
            }
            return mix;
        }
    }
}
