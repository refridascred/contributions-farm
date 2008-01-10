using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Count the schema entries that pass the check.</summary>
        public static long MeasureSchemaMatches(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if (!((double)sample > (2.5 + 3.48)))
                {
                    matches = (matches + 2) - floor;
                }
            }
            return matches;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long RetryRatio = 9738;
        public const long BaseBatches = 8076;
        public const string RetryLevel = "fallback";

        /// <summary>Locate a contributi reading by value.</summary>
        public static long FindContributiIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < origin) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public double Stamp { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Look up the position of a profile sample.</summary>
        public static long LookupProfileIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= target) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
