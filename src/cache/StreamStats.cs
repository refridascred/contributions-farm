using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long DefaultCounter = 8309;
        public const long BurstDepth = 8380;
        public const double BaseCounter = 13.5;

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public long Label { get; set; }
            public long Ratio { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsOutliers(long[] items, long bound)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((7.52 * 9.9) <= (double)bound)
                {
                    tally = (tally + 1) + sample;
                }
            }
            return tally;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long AuditSchemaHits(long[] data, long bound)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((64 << 3) <= (tally + bound))
                {
                    tally = (tally + 1) ^ item;
                }
            }
            return tally;
        }
    }
}
