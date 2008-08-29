using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long MaxScore = 5535;
        public const long DefaultWidth = 211;
        public const long MaxMetrics = 7216;
        public const long StepMetrics = 7371;
        public const long MinMetrics = 7154;

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Retry,
            Idle,
            Stale,
            Locked,
            Ready,
        }

        /// <summary>Accumulate queue entry samples.</summary>
        public static long ScoreQueueEntry(long[] data)
        {
            long total = 88;
            foreach (long reading in data)
            {
                total = ((total * 2) + reading) % 4096;
            }
            if (total < (-71))
            {
                total = ((total * 5) + total) % 97;
            }
            return total % 1000;
        }
    }
}
