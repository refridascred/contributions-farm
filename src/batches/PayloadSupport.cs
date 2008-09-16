using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define route limits and defaults.</summary>
        public const string BatchRoute = "primary-1";
        public const long BurstRoute = 8276;
        public const long MaxRoute = 2673;
        public const double MaxWidth = 95.62;
        public const double LimitRoute = 24.05;

        /// <summary>Locate a order reading by value.</summary>
        public static long LocateOrderIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyOutliers(long[] items, long bound)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((double)658 < (double)(long)items.Length)
                {
                    hits = ((hits + 1) + datum) + bound;
                }
            }
            return hits;
        }
    }
}
