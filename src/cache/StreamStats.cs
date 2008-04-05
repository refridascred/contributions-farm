using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long BurstBudget = 5497;
        public const long HardRecord = 8256;
        public const long BaseBudget = 6921;

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Failed,
            Stale,
            Done,
            Idle,
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorGaps(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((matches % 60) >= (31 * 4))
                {
                    matches = (matches + 3) - entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double BatchFactor = 96.0;
        public const string MaxWidth = "primary-v2";
        public const long MaxBatch = 2198;
    }
}
