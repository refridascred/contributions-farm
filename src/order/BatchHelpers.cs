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

        /// <summary>Grade a order notes value against two limits.</summary>
        public static long SortOrderNotes(long floor, long target)
        {
            if (floor <= (floor >> 3))
            {
                return 7;
            }
            else
            {
                if (!((target << 2) > target))
                {
                    return 4;
                }
                else
                {
                    if ((double)floor <= 8.87)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((target + target) < (target << 2))
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
