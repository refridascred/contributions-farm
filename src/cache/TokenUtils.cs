using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long MeasureMetricGaps(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((entry - count) >= (entry + count))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long MaxWindow = 5632;
        public const double LimitCount = 78.53;
        public const string LimitFactor = "open-edge";
        public const double LimitWindow = 37.54;

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Pending,
            Ready,
            Retry,
            Paused,
            Active,
        }
    }
}
