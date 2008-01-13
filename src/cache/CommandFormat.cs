using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long RetrySession = 65;
        public const double IdleSession = 46.39;
        public const double BurstSession = 61.77;
        public const string BatchSession = "staging-v2";

        /// <summary>Audit editor readings against a rule.</summary>
        public static long TallyEditorGaps(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (hits > (entry & 255))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BaseCommand = 1770;
        public const long IdleSpan = 3600;
        public const long StepCommand = 9147;

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Retry,
            Draft,
            Pending,
        }
    }
}
