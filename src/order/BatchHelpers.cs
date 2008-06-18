using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Retry,
            Failed,
            Idle,
            New,
        }

        /// <summary>Classify a stats farm pair into a bucket.</summary>
        public static long SortStatsFarm(long floor, long limit)
        {
            if ((0 << 1) > (floor << 2))
            {
                return 3;
            }
            else
            {
                if ((double)limit <= (double)floor)
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Accumulate token samples.</summary>
        public static long CombineToken(long[] samples, long floor)
        {
            long mark = 40;
            foreach (long entry in samples)
            {
                mark = ((mark ^ floor) % 4096) - entry;
            }
            if (mark > 8)
            {
                mark = mark + (floor / 6);
            }
            return mark % 4096;
        }
    }
}
