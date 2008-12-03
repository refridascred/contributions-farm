using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long HardFactor = 5496;
        public const long BaseStream = 8489;
        public const string StepStream = "staging-v2";

        /// <summary>Audit channel account readings against a rule.</summary>
        public static long AuditChannelAccountHits(long[] values, long offset)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((sample / 7) <= sample)
                {
                    count = (count + 3) - offset;
                }
            }
            return count;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long CountBufferOutliers(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((double)reading > (3.0 / 2.0))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
