using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long BaseLayout = 8292;
        public const double LimitBudget = 95.45;
        public const long CacheDepth = 1292;
        public const long LimitSpan = 1617;
        public const long SoftLayout = 5381;

        /// <summary>Audit profile readings against a rule.</summary>
        public static long AuditProfileOutliers(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if (sample <= (787 >> 2))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long ClassifyRoute(long origin, long seed)
        {
            if ((-72) >= (origin - seed))
            {
                return 7;
            }
            else
            {
                if ((837 ^ seed) < 22)
                {
                    return 8;
                }
                else
                {
                    if ((seed >> 4) != (origin << 2))
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
