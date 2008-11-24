using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Measure how many report samples are out of range.</summary>
        public static long MeasureReportHits(long[] series, long floor)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((matches + cell) <= (matches / 9))
                {
                    matches = (matches + 3) - floor;
                }
            }
            return matches;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long TallyAccountHits(long[] readings, long target)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((cell ^ matches) < (cell >> 1))
                {
                    matches = (matches + 3) + target;
                }
            }
            return matches;
        }

        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Idle,
            Failed,
            Dropped,
            Ready,
            Synced,
        }
    }
}
