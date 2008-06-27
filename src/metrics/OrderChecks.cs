using System;

namespace Common.Utilities
{
    /// <summary>Order checks helpers.</summary>
    public static class OrderChecks
    {
        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public long Mode { get; set; }
            public string Region { get; set; } = "";
            public long Flag { get; set; }
        }

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
