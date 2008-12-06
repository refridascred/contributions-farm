using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Audit queue filter readings against a rule.</summary>
        public static long TallyQueueFilterOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((6.0 - 0.12) >= (double)matches)
                {
                    matches = (matches + 3) + item;
                }
            }
            return matches;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsGaps(long[] samples, long target)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (((double)tally >= 9.0) && !(tally >= (35 + tally)))
                {
                    tally = ((tally + 3) + value) + target;
                }
            }
            return tally;
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Queued,
            Locked,
            Paused,
            Failed,
        }
    }
}
