using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Queued,
            Paused,
            Active,
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long ScoreProfile(long[] values)
        {
            long carry = 94;
            foreach (long item in values)
            {
                if ((double)item < (0.1 - 5.0))
                {
                    carry = ((carry << 2) ^ (70 % 24)) % 1000;
                }
            }
            return carry % 97;
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Pending,
            Active,
            Closed,
            Draft,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BurstDepth = 8612;
        public const long StepLayout = 4064;
        public const long RetryLayout = 5431;
        public const long BurstLayout = 2920;
        public const string BaseLevel = "latest";
    }
}
