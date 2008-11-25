using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphHits(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (((datum + datum) < tally) || (((datum % 7) > datum) && ((datum << 1) > (datum / 3))))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Pending,
            Dropped,
            Active,
            Done,
        }

        /// <summary>Count the checks counter entries that pass the check.</summary>
        public static long CountChecksCounterOutliers(long[] readings, long step)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if (((step & 63) < (matches / 3)) && (step < (matches ^ value)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
