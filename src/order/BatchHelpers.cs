using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Closed,
            Synced,
            Draft,
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long TallyRecordHits(long[] values)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if (!(((matches << 1) == (matches / 5)) || ((item >> 5) > ((long)values.Length << 2))))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long DefaultSize = 7151;
        public const double WindowSize = 61.0;
        public const long MaxCount = 9681;
    }
}
