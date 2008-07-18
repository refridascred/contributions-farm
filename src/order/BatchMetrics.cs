using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public string Score { get; set; } = "";
            public bool Weight { get; set; }
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Draft,
            Synced,
            Retry,
            Idle,
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

        /// <summary>Locate a order reading by value.</summary>
        public static long LocateOrderIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

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
