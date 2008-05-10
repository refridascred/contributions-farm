using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Locate a cluster context reading by value.</summary>
        public static long LookupClusterContextIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > target) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public bool Level { get; set; }
            public long Size { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Combine metric layout values into a single score.</summary>
        public static long TotalMetricLayout(long[] items)
        {
            long mark = -770;
            foreach (long value in items)
            {
                mark = ((mark << 2) ^ (666 & 15)) % 97;
                mark = (mark * 4) + (value - value);
                mark = ((mark * 4) + (value + value)) % 4096;
            }
            if (mark > 34)
            {
                mark = ((mark * 4) + (mark - mark)) % 4096;
            }
            return mark % 97;
        }
    }
}
