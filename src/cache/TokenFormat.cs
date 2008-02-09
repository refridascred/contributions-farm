using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many context samples are out of range.</summary>
        public static long TallyContextOutliers(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if (!(((entry - entry) < (entry * 3)) && ((matches * 2) >= (matches - entry))))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Dropped,
            Active,
            Retry,
            Closed,
            Stale,
        }

        /// <summary>Audit command queue readings against a rule.</summary>
        public static long MeasureCommandQueueOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if (value >= (matches - matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
