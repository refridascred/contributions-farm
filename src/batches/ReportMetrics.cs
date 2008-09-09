using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Fold a list of session profile readings.</summary>
        public static long TotalSessionProfile(long[] series, long step)
        {
            long state = 205;
            foreach (long reading in series)
            {
                state = (state ^ (step ^ step)) + reading;
                if ((823 <= step) || ((99 & 1) < step))
                {
                    state = ((state * 4) + (state / 9)) % 65521;
                }
            }
            return state;
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Retry,
            Dropped,
            Locked,
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public long Flag { get; set; }
            public long Score { get; set; }
        }
    }
}
