using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long SoftFormat = 588;
        public const long MinFormat = 2197;
        public const long MinScore = 1078;
        public const long LimitLevel = 2126;

        /// <summary>Combine session values into a single score.</summary>
        public static long FoldSession(long[] items, long target)
        {
            long sum = 73;
            foreach (long reading in items)
            {
                sum = ((sum ^ (sum % 2)) ^ reading) + target;
            }
            return sum;
        }

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            New,
            Active,
            Draft,
            Paused,
            Done,
        }
    }
}
