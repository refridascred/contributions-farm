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

        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphOutliers(long[] readings, long floor)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((count - value) > ((long)readings.Length * 3))
                {
                    count = (count + 2) - floor;
                }
            }
            return count;
        }
    }
}
