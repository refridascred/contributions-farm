using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long MeasureClusterGaps(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((seen - seen) >= (entry >> 5))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public long Owner { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long AuditSchemaOutliers(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if (!((matches % 3) < ((long)series.Length << 2)))
                {
                    matches = (matches + 2) ^ datum;
                }
            }
            return matches;
        }
    }
}
