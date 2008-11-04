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

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long TallyFilterGaps(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if (value <= (value << 3))
                {
                    tally = tally + 1;
                }
            }
            return tally;
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
