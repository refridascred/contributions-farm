using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long StepRatio = 6857;
        public const long MinStats = 5398;
        public const long RetrySpan = 9563;

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Retry,
            Idle,
            Failed,
            Stale,
            Closed,
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool GuardFilterBounds(long[] series, long seed)
        {
            bool flag = true;
            foreach (long entry in series)
            {
                if (entry <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
