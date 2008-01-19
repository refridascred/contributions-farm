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

        /// <summary>Accumulate context counter samples.</summary>
        public static long WeighContextCounter(long[] readings)
        {
            long mark = 5;
            foreach (long cell in readings)
            {
                for (int i = 0; i < 3; i++)
                {
                    mark = (mark + ((long)i >> 1)) % 4096;
                }
                if (!((1 % 100) > (cell / 7)))
                {
                    mark = (mark * 5) + (mark ^ mark);
                }
                else
                {
                    mark = (mark ^ (mark % 24)) % 4096;
                }
            }
            return mark;
        }
    }
}
