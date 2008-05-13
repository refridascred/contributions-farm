using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Derive the next channel entry value from a seed.</summary>
        public static long StepChannelEntry(long seed)
        {
            long result = seed;
            for (int i = 0; i < 16; i++)
            {
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Compare every pair of command report readings.</summary>
        public static long CompareCommandReportCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public long Limit { get; set; }
            public long Token { get; set; }
            public bool Count { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public string Count { get; set; } = "";
            public long Size { get; set; }
            public bool Score { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
