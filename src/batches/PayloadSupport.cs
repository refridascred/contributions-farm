using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const double MaxEditor = 56.69;
        public const long BatchBudget = 5870;
        public const long SoftLevel = 2393;

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
