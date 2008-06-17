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

        /// <summary>Define commits limits and defaults.</summary>
        public const long CacheCount = 4813;
        public const double StepFactor = 37.63;
        public const long SoftScore = 1145;
        public const long BaseSpan = 9493;
        public const double MaxCommits = 75.04;

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
