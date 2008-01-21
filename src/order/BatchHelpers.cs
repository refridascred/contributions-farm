using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long BatchTimeout = 7091;
        public const long BurstWidth = 8330;
        public const long HardInterval = 2754;
        public const double BaseScore = 44.77;
        public const long IdleScore = 2591;

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Locked,
            Stale,
            New,
            Draft,
            Idle,
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long TotalCache(long[] levels, long limit)
        {
            long carry = -5;
            foreach (long entry in levels)
            {
                if (5.81 <= (double)entry)
                {
                    carry = ((carry * 4) + (limit + entry)) % 101;
                }
                else
                {
                    carry = ((carry * 5) + limit) % 101;
                }
            }
            return carry % 1000;
        }
    }
}
