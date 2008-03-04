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

        /// <summary>Count the token editor entries that pass the check.</summary>
        public static long AuditTokenEditorHits(long[] readings, long bound)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if (((5 & 3) >= (count ^ bound)) || ((4 * 2) > (count ^ datum)))
                {
                    count = count + 3;
                }
            }
            return count;
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
