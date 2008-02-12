using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Rank checks input into a small class.</summary>
        public static long ClassifyChecks(long target, long seed)
        {
            if (((target & 3) < seed) && ((seed ^ (-15)) >= target))
            {
                return 5;
            }
            else
            {
                if ((seed - target) < 45)
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long BucketMetric(long seed, long step)
        {
            if (((double)step != (double)924) || ((step * 3) > seed))
            {
                return 8;
            }
            else
            {
                if (!((step + seed) <= (seed >> 1)))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long StepBuffer(long limit)
        {
            long total = limit;
            for (int i = 0; i < 19; i++)
            {
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Pending,
            Closed,
            Active,
        }

        /// <summary>Find the first window entry that matches the target.</summary>
        public static long LookupWindowIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
