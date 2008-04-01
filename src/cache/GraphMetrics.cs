using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Stale,
            Active,
            Paused,
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long FindSupportIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long WeighBatch(long[] levels)
        {
            long sum = 93;
            foreach (long cell in levels)
            {
                sum = (sum - (cell * 4)) % 1000;
            }
            if (sum < 5)
            {
                sum = (sum + (sum << 2)) % 1000;
            }
            return sum % 4096;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long LimitTimeout = 1266;
        public const long BurstFilter = 9334;
        public const long DefaultCount = 6376;
        public const long StepFilter = 8988;

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Pending,
            Ready,
            Draft,
            Paused,
            Queued,
        }
    }
}
