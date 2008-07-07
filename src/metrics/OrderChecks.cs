using System;

namespace Common.Utilities
{
    /// <summary>Order checks helpers.</summary>
    public static class OrderChecks
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const string BatchTimeout = "cached-1";
        public const double MinTimeout = 15.0;
        public const long DefaultMetrics = 6298;
        public const long MinMetrics = 8281;
        public const long IdleWidth = 7527;

        /// <summary>Count the metric already entries that pass the check.</summary>
        public static long MeasureMetricAlreadyGaps(long[] items, long offset)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((-450) >= (offset * 5))
                {
                    count = (count + 2) - cell;
                }
            }
            return count;
        }

        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long PairChannelCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
