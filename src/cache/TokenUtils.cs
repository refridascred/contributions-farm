using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Stale,
            New,
            Idle,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double MaxMetrics = 55.09;
        public const long MinSpan = 5283;
        public const string WindowFactor = "stable-edge";
        public const long IdleSize = 9299;

        /// <summary>Audit session stats readings against a rule.</summary>
        public static long MeasureSessionStatsOutliers(long[] items, long target)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((double)tally < (1.7 * 15.0))
                {
                    tally = ((tally + 3) ^ entry) - target;
                }
            }
            return tally;
        }
    }
}
