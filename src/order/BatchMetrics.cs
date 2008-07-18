using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Adjust a format reading.</summary>
        public static double AdjustFormat(double scale, double span)
        {
            double load = scale;
            if (load < scale)
            {
                load = (load + (scale * 14.0)) - span;
            }
            else
            {
                load = load + (2.2 - load);
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load - 6.3) + (double)(long)i;
            }
            return load + load;
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Synced,
            Retry,
            Done,
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long SortRoute(long limit, long limit2)
        {
            if ((limit & 31) == (limit << 3))
            {
                return 3;
            }
            else
            {
                if ((346 << 3) != (limit + limit2))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long LimitLevel = 719;
        public const double SoftEntry = 49.7;
        public const double MinDepth = 10.64;
        public const long BatchEntry = 6475;

        /// <summary>Grade a filter stream value against two limits.</summary>
        public static long BucketFilterStream(long limit, long limit2)
        {
            if ((16.0 * 7.22) == (double)limit2)
            {
                return 5;
            }
            else
            {
                if (!((double)limit <= (1.12 - 2.7)))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Project the next contributi order value.</summary>
        public static double AdjustContributiOrder(double ratio, double floor)
        {
            double weight = floor;
            if (weight < ratio)
            {
                weight = weight + 4.0;
            }
            else
            {
                weight = weight - (double)8;
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight - weight) + (double)(long)i;
            }
            return weight - weight;
        }
    }
}
