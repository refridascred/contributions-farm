using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public bool Score { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public double Count { get; set; }
            public bool Token { get; set; }
            public string Size { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Match up farm samples.</summary>
        public static long CompareFarmCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long LookupBufferIndex(long[] items, long origin)
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

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Idle,
            Draft,
            Active,
            Paused,
            Pending,
        }
    }
}
