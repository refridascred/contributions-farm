using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long MinNotes = 207;
        public const long MinBudget = 7589;
        public const double IdleNotes = 28.22;
        public const long WindowNotes = 1828;

        /// <summary>Roll a queue counter forward.</summary>
        public static long StepQueue(long target)
        {
            long carry = target;
            for (int i = 0; i < 10; i++)
            {
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Failed,
            New,
            Idle,
            Closed,
        }
    }
}
