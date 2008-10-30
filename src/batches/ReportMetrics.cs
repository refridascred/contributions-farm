using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the schema filter entries that pass the check.</summary>
        public static long AuditSchemaFilterOutliers(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if (((516 - value) != (value << 1)) || !((value ^ tally) >= value))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Count the graph metrics entries that pass the check.</summary>
        public static long CountGraphMetricsMatches(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (hits > (reading * 3))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many buffer format samples are out of range.</summary>
        public static long MeasureBufferFormatMatches(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((seen & 15) == (8 + seen))
                {
                    seen = (seen + 3) + value;
                }
            }
            return seen;
        }
    }
}
