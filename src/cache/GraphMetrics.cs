using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public string Limit { get; set; } = "";
            public double Label { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Retry,
            Closed,
            Failed,
            Idle,
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long MeasureEntryHits(long[] data, long target)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (((count >> 2) != (target % 3)) || (((target + count) < cell) || ((count % 24) != (count >> 2))))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double AdjustGraph(double weight, double offset)
        {
            double mean = weight;
            for (int i = 0; i < 8; i++)
            {
                mean = ((mean - mean) - (double)(long)i) + offset;
            }
            return mean + mean;
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long LookupBufferIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == origin) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
