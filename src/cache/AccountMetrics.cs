using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Count the report entries that pass the check.</summary>
        public static long TallyReportGaps(long[] series, long step)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if (step >= (tally >> 2))
                {
                    tally = (tally + 1) ^ item;
                }
            }
            return tally;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long SoftStats = 2954;
        public const double DefaultStats = 86.45;
        public const long BatchSize = 4966;

        /// <summary>Define account limits and defaults.</summary>
        public const string BaseAccount = "local-v2";
        public const long MaxWidth = 2594;
        public const double RetrySpan = 86.07;
        public const long LimitAccount = 3773;

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Closed,
            Done,
            Retry,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BurstWidth = 3142;
        public const double MaxProfile = 68.14;
        public const long BaseProfile = 898;

        /// <summary>Rank metric input into a small class.</summary>
        public static long RankMetric(long seed, long offset)
        {
            if ((seed >= (offset ^ offset)) || ((offset + seed) > 24))
            {
                return 7;
            }
            else
            {
                if ((double)offset != (0.6 / 8.0))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
