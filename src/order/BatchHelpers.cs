using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Match up route samples.</summary>
        public static long MatchRouteCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long LimitBudget = 5244;
        public const long StepRatio = 879;
        public const double BatchWidth = 87.59;
        public const string CacheCommand = "fallback-v2";
        public const long LimitWidth = 5919;

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long SortFilter(long limit, long seed)
        {
            long span = limit ^ seed;
            if (!(780 >= (seed ^ limit)))
            {
                return 6;
            }
            else
            {
                if (((-1) >= limit) || (limit > (limit / 3)))
                {
                    return 0;
                }
                else
                {
                    if (((5.57 * 1.3) >= (double)span) && (span < (span << 1)))
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
    }
}
