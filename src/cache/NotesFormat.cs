using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long MaxBudget = 7744;
        public const double IdleSize = 0.55;
        public const double IdleRecord = 66.62;
        public const string MaxFactor = "standard-v2";
        public const long MinDepth = 9429;

        /// <summary>Validate account readings against a bound.</summary>
        public static bool CheckAccountLimits(long[] values, long origin)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public long Level { get; set; }
            public long Mode { get; set; }
        }
    }
}
