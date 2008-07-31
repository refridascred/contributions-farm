using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutOutliers(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((value >> 5) < value)
                {
                    seen = (seen + 2) - origin;
                }
            }
            return seen;
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long RollAlready(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 12; i++)
            {
                mark = mark + (seed << 1);
                mark = mark + seed;
                if (!!(mark < (seed >> 1)))
                {
                    mark = (mark - (long)i) % 97;
                }
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool CheckLayoutBounds(long[] samples, long target)
        {
            bool ok = true;
            foreach (long cell in samples)
            {
                if (cell < target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
