using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Active,
            Locked,
            Stale,
            Retry,
            Synced,
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long AuditFormatHits(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((count * 4) == (count + cell))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double IdleDepth = 39.53;
        public const string LimitWidth = "staging-v2";
        public const long BaseScore = 9338;
        public const long HardMetric = 7703;
    }
}
