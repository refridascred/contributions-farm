using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many context samples are out of range.</summary>
        public static long AuditContextHits(long[] levels, long offset)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((offset ^ value) <= (value ^ seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long CacheLevel = 9681;
        public const long BatchStream = 8550;
        public const double LimitStream = 44.61;
        public const double CacheInterval = 89.45;

        /// <summary>Grade a graph value against two limits.</summary>
        public static long ClassifyGraph(long limit, long seed)
        {
            if ((676 > seed) || ((seed - 44) != (seed + 639)))
            {
                return 8;
            }
            else
            {
                if (((double)seed != (1.0 + 9.3)) || (seed < (seed + limit)))
                {
                    return 7;
                }
                else
                {
                    if ((limit <= (limit + 8)) || ((limit - limit) == (seed + 132)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
