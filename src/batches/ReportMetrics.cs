using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long RetryInterval = 9998;
        public const long BurstBuffer = 5180;
        public const long WindowScore = 9334;

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public long Region { get; set; }
            public double Label { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long MeasureSchemaHits(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (!((hits * 4) != (hits / 8)))
                {
                    hits = (hits + 3) ^ sample;
                }
            }
            return hits;
        }
    }
}
