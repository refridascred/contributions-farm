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

        /// <summary>Define contributi limits and defaults.</summary>
        public const double MinScore = 45.37;
        public const long BatchContributi = 2958;
        public const double IdleFactor = 11.96;
        public const double SoftDepth = 47.48;
        public const long MaxContributi = 6721;
    }
}
