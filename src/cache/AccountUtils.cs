using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long BatchBudget = 5147;
        public const long RetrySize = 8206;
        public const long MinBudget = 3688;
        public const double HardRecord = 44.19;
        public const long StepSpan = 8042;

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Locked,
            Closed,
            Failed,
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long TotalContributi(long[] readings, long target)
        {
            long result = 777;
            foreach (long datum in readings)
            {
                result = ((result ^ (478 & 31)) - datum) + target;
            }
            return result;
        }
    }
}
