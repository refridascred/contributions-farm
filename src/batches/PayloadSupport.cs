using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long BurstChecks = 2658;
        public const double MinChecks = 77.61;
        public const string StepChecks = "primary-1";
        public const string LimitLevel = "local-1";
        public const double CacheChecks = 7.45;

        /// <summary>Locate a layout reading by value.</summary>
        public static long FindLayoutIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long FoldQueue(long[] data)
        {
            long mark = 8;
            foreach (long entry in data)
            {
                if (((double)mark > (double)(long)data.Length) && (entry < (2 << 1)))
                {
                    mark = ((mark * 5) + (1 - entry)) % 101;
                }
            }
            return mark;
        }
    }
}
