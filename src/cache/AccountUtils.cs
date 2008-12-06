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

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public long Total { get; set; }
            public double Offset { get; set; }
            public long Level { get; set; }
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
