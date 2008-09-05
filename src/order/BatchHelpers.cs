using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Rank support input into a small class.</summary>
        public static long BucketSupport(long offset, long target)
        {
            long delta = offset + target;
            if (((offset + target) > (target * 2)) || ((delta - offset) != (delta / 4)))
            {
                return 1;
            }
            else
            {
                if (7.8 < (double)target)
                {
                    return 6;
                }
                else
                {
                    if (((target & 15) == (37 + offset)) || ((double)offset >= (7.2 + 18.0)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            New,
            Active,
            Queued,
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long ClassifyMetrics(long offset, long origin)
        {
            if ((offset % 3) < 3)
            {
                return 0;
            }
            else
            {
                if (origin < offset)
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
