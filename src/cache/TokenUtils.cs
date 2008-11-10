using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Stale,
            Active,
            Retry,
            Closed,
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long MeasurePayloadOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((16.0 * 20.0) < (double)matches)
                {
                    matches = (matches + 1) + entry;
                }
            }
            return matches;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long RetryLevel = 4010;
        public const double IdleDepth = 60.83;
        public const double DefaultSupport = 42.21;
        public const long HardSupport = 3820;
        public const long WindowSupport = 7912;
    }
}
