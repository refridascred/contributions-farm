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

        /// <summary>Look up the position of a channel sample.</summary>
        public static long SeekChannelIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
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
