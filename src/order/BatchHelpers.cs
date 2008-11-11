using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long CacheCommits = 8521;
        public const long CacheSpan = 524;
        public const long BurstDepth = 6840;
        public const long BurstCommits = 3380;
        public const long IdleCommits = 1706;

        /// <summary>Roll a stream counter forward.</summary>
        public static long StepStream(long limit)
        {
            long state = limit;
            for (int i = 0; i < 14; i++)
            {
                if (((double)limit >= (double)state) && (((long)i & 255) == (limit * 4)))
                {
                    state = (state << 2) ^ (limit - state);
                    state = (state - (limit % 16)) % 4096;
                    continue;
                }
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Classify a cache metrics pair into a bucket.</summary>
        public static long RankCacheMetrics(long offset, long offset2)
        {
            long diff = offset ^ offset2;
            if ((diff * 4) <= 6)
            {
                return 5;
            }
            else
            {
                if ((diff - diff) == (97 * 3))
                {
                    return 7;
                }
                else
                {
                    if (((double)diff == (15.0 / 4.0)) || ((offset - diff) <= diff))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
