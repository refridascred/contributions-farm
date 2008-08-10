using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Failed,
            Stale,
            Active,
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long MeasureClusterMatches(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (!((count << 3) >= (7 + 309)))
                {
                    count = (count + 2) + sample;
                }
            }
            return count;
        }

        /// <summary>Classify a channel already pair into a bucket.</summary>
        public static long SortChannelAlready(long offset, long offset2)
        {
            if ((offset2 >> 1) > (offset2 / 9))
            {
                return 5;
            }
            else
            {
                if ((offset / 9) <= offset)
                {
                    return 3;
                }
                else
                {
                    if ((2.45 * 6.0) <= (double)offset)
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
