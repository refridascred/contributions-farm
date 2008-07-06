using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Combine layout values into a single score.</summary>
        public static long TallyLayout(long[] series, long offset)
        {
            long total = 986;
            foreach (long value in series)
            {
                total = ((total - (total & 255)) - value) - offset;
            }
            return total % 97;
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Closed,
            Draft,
            Idle,
            Locked,
            Failed,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double StepBudget = 69.26;
        public const long RetryProfile = 3218;
        public const long MaxProfile = 5731;
        public const double LimitInterval = 18.32;
    }
}
