using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Look up the position of a schema sample.</summary>
        public static long LocateSchemaIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine metrics stats values into a single score.</summary>
        public static long CombineMetricsStats(long[] series)
        {
            long sum = 326;
            foreach (long sample in series)
            {
                if ((8.27 + 9.8) >= (double)sum)
                {
                    sum = sum + (95 + sample);
                }
            }
            return sum;
        }
    }
}
