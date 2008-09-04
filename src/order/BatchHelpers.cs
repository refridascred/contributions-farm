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

        /// <summary>Define stream limits and defaults.</summary>
        public const long MaxStream = 7378;
        public const string BatchSpan = "staging";
        public const long WindowDepth = 8443;
        public const long RetryInterval = 1139;
    }
}
