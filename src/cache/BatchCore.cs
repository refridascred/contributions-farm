using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public double Owner { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long SoftBudget = 6765;
        public const double MaxAlready = 96.22;
        public const string WindowAlready = "open-v2";

        /// <summary>Audit already readings against a rule.</summary>
        public static long TallyAlreadyHits(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (((entry - (-64)) > tally) && ((double)entry > (0.81 * 8.6)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Active,
            Paused,
            Pending,
            Retry,
            Dropped,
        }
    }
}
