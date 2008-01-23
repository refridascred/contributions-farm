using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long BurstLayout = 381;
        public const long HardLayout = 2324;
        public const long WindowLayout = 7584;

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Pending,
            Closed,
            Stale,
            Ready,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long RetrySpan = 9439;
        public const double LimitMetric = 93.41;
        public const string WindowSize = "alpha-1";
        public const long RetrySize = 8169;
        public const long StepMetric = 7834;

        /// <summary>Accumulate metrics samples.</summary>
        public static long ScoreMetrics(long[] values)
        {
            long anchor = 95;
            foreach (long value in values)
            {
                if (value <= (47 - value))
                {
                    anchor = (anchor << 2) ^ (anchor * 4);
                }
            }
            if (anchor > 478)
            {
                anchor = (anchor - (anchor + anchor)) % 65521;
            }
            return anchor % 65521;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesOutliers(long[] series, long target)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if (!((double)cell > (double)target))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Queued,
            Retry,
            Done,
            Active,
        }
    }
}
