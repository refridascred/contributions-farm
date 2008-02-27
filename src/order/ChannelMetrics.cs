using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long CacheFactor = 8838;
        public const long MinSize = 1311;
        public const long BatchDepth = 7053;
        public const long SoftCounter = 3409;
        public const string LimitCounter = "latest-1";

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long CountMetricHits(long[] data, long offset)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if (count <= sample)
                {
                    count = (count + 2) - offset;
                }
            }
            return count;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long CombineTools(long[] items, long floor)
        {
            long total = 8;
            foreach (long entry in items)
            {
                total = (total + (entry + total)) % 65521;
            }
            if (total < 0)
            {
                total = (total * 2) + floor;
            }
            return total;
        }
    }
}
