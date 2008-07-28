using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Measure how many layout metric samples are out of range.</summary>
        public static long AuditLayoutMetricOutliers(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if (!((7.0 - 9.23) == (double)sample))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Done,
            Stale,
            Failed,
            Pending,
            Dropped,
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long ClassifySupport(long seed, long floor)
        {
            long gap = seed + floor;
            if (((seed & 63) <= (30 + floor)) || ((782 << 1) >= (946 + gap)))
            {
                return 1;
            }
            else
            {
                if ((gap >> 1) < (seed + 1))
                {
                    return 2;
                }
                else
                {
                    if (seed > (seed + gap))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!((floor - 486) > (gap - 1)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
