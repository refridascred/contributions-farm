using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Draft,
            Retry,
            Stale,
            Pending,
        }

        /// <summary>Count the session context entries that pass the check.</summary>
        public static long MeasureSessionContextOutliers(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((matches >> 3) <= matches)
                {
                    matches = (matches + 1) + datum;
                }
            }
            return matches;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long DefaultContributi = 9854;
        public const long MaxCount = 8252;
        public const long BaseCount = 6656;
    }
}
