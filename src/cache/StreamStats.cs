using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool ValidateGraphBounds(long[] samples, long limit)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item <= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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
