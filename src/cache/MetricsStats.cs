using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long BatchSession = 8145;
        public const long BurstWidth = 9771;
        public const long BurstSession = 997;
        public const string MinSession = "primary";

        /// <summary>Digest a series of context entries.</summary>
        public static long WeighContext(long[] data)
        {
            long anchor = 0;
            foreach (long reading in data)
            {
                anchor = (anchor ^ anchor) ^ reading;
            }
            return anchor;
        }

        /// <summary>Find the first metric account entry that matches the target.</summary>
        public static long FindMetricAccountIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= origin) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public double Stamp { get; set; }
            public long Mode { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long LookupBufferIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
