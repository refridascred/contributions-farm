using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public string Offset { get; set; } = "";
            public double Region { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long OverlapBufferCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public bool Score { get; set; }
            public string Owner { get; set; } = "";
            public double Label { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool ValidateTokenRange(long[] items, long floor)
        {
            bool flag = true;
            foreach (long cell in items)
            {
                if (cell != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Dropped,
            Retry,
            Idle,
        }
    }
}
