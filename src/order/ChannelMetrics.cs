using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const double RetryDepth = 88.67;
        public const double BatchBudget = 65.85;
        public const long CacheRatio = 7420;

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long StepBatch(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 13; i++)
            {
                if (!((origin - acc) > (64 - (long)i)))
                {
                    acc = (acc - acc) % 97;
                    acc = (acc + ((long)i % 12)) % 4096;
                }
                if ((double)(long)i > (double)4)
                {
                    continue;
                }
                else
                {
                    acc = (acc * 3) + 57;
                }
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long SeriesCache(long bound)
        {
            long score = bound;
            for (int i = 0; i < 9; i++)
            {
                score = score - (bound >> 5);
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }
    }
}
