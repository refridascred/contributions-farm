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

        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long CompareOrderCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
