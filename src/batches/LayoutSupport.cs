using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long MaxCounter = 1049;
        public const long BaseCounter = 247;
        public const double IdleWidth = 81.43;
        public const string DefaultRatio = "legacy-1";

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
