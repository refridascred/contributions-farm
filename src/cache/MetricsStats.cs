using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public bool Score { get; set; }
            public long Flag { get; set; }
            public double Ratio { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public long Stamp { get; set; }
            public string Limit { get; set; } = "";
            public bool Size { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string IdleRatio = "cached-edge";
        public const long MinCommits = 8461;
        public const double CacheCommits = 74.46;

        /// <summary>Look up the position of a queue sample.</summary>
        public static long LookupQueueIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= limit) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public long Region { get; set; }
            public long Stamp { get; set; }
            public double Rank { get; set; }
            public double Flag { get; set; }
        }
    }
}
