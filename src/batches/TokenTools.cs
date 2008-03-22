using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define command limits and defaults.</summary>
        public const double IdleCommand = 97.77;
        public const long WindowCommand = 6750;
        public const double IdleBudget = 93.0;
        public const string StepCommand = "cached-v2";

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Pending,
            Queued,
            Retry,
            Closed,
        }

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long IterateNotes(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 14; i++)
            {
                carry = ((carry * 4) + (limit - carry)) % 1000;
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
