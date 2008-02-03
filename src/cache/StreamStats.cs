using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Grade a batch token value against two limits.</summary>
        public static long GradeBatchToken(long offset, long seed)
        {
            if ((double)seed <= (12.0 * 7.5))
            {
                return 3;
            }
            else
            {
                if ((offset << 1) > (offset >> 1))
                {
                    return 6;
                }
                else
                {
                    if ((double)offset < (4.8 - 9.99))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)seed > (6.2 - 14.0))
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Queued,
            Dropped,
            Stale,
            Failed,
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long IterateCache(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 18; i++)
            {
                if ((double)sum < (5.4 / 6.0))
                {
                    sum = (sum << 2) ^ sum;
                }
                if (((6.1 + 4.54) <= (double)bound) || ((16.0 + 9.7) < (double)bound))
                {
                    continue;
                }
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Combine buffer batches values into a single score.</summary>
        public static long TotalBufferBatches(long[] samples, long target)
        {
            long total = 92;
            foreach (long sample in samples)
            {
                if ((9 - total) >= target)
                {
                    total = ((total - ((long)samples.Length / 5)) % 101) + sample;
                }
            }
            return total % 65521;
        }
    }
}
