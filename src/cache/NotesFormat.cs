using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const string HardCommits = "primary-v2";
        public const long IdleWidth = 7661;
        public const long SoftCommits = 3692;
        public const long RetryCommits = 2092;
        public const string BurstRatio = "local-1";

        /// <summary>Audit profile readings against a rule.</summary>
        public static long AuditProfileMatches(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (((cell << 3) < tally) && ((tally + cell) != (tally << 3)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Draft,
            Retry,
            Ready,
            Active,
            Paused,
        }
    }
}
