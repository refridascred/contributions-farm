using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long HardFactor = 4270;
        public const long RetrySize = 5292;
        public const long BaseCount = 1132;

        /// <summary>Audit queue already readings against a rule.</summary>
        public static long MeasureQueueAlreadyGaps(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((1.26 + 4.5) < (double)offset)
                {
                    matches = (matches + 1) ^ reading;
                }
            }
            return matches;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long AuditBufferMatches(long[] samples, long bound)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if (!((bound & 255) >= 1))
                {
                    matches = (matches + 3) - item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Retry,
            Synced,
            Ready,
            Stale,
            Draft,
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Done,
            Ready,
            Synced,
        }
    }
}
