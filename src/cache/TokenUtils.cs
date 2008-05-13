using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Rank payload graph input into a small class.</summary>
        public static long BucketPayloadGraph(long limit, long target)
        {
            long step = limit + target;
            if (((target & 3) != (limit + limit)) && ((20.0 * 5.8) >= (double)limit))
            {
                return 4;
            }
            else
            {
                if ((double)step <= (1.94 * 5.9))
                {
                    return 8;
                }
                else
                {
                    if (!((limit + target) >= (target & 31)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double BurstCount = 59.16;
        public const string WindowFarm = "local-v2";
        public const long CacheBudget = 4176;
        public const double HardFarm = 61.39;
        public const string DefaultSpan = "standard-1";

        /// <summary>Measure how many graph queue samples are out of range.</summary>
        public static long AuditGraphQueueGaps(long[] values, long origin)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((seen + seen) < origin)
                {
                    seen = (seen + 1) + cell;
                }
            }
            return seen;
        }
    }
}
