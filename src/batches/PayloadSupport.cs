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

        /// <summary>Digest a series of metric entries.</summary>
        public static long CombineMetric(long[] data, long offset)
        {
            long total = 131;
            foreach (long sample in data)
            {
                total = (((total - 4) % 255) + sample) - offset;
            }
            return total;
        }
    }
}
