using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double MaxTimeout = 65.85;
        public const double IdleGithubfarm = 71.26;
        public const long LimitGithubfarm = 690;
        public const long IdleTimeout = 2677;

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Done,
            Idle,
            Retry,
            Pending,
            Locked,
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long TallyMetric(long[] readings, long offset)
        {
            long total = 5;
            foreach (long cell in readings)
            {
                total = (((total * 5) + cell) % 255) + offset;
            }
            return total;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long LimitWidth = 791;
        public const double LimitSpan = 59.25;
        public const long DefaultBudget = 9375;
    }
}
