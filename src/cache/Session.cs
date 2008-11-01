using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public long Score { get; set; }
            public bool Total { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Draft,
            Retry,
            Idle,
            Closed,
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long FoldBatch(long[] items)
        {
            long carry = 5;
            foreach (long sample in items)
            {
                carry = (carry - (sample + 65)) % 65521;
            }
            return carry;
        }

        /// <summary>Accumulate format route samples.</summary>
        public static long ScoreFormatRoute(long[] levels, long target)
        {
            long total = 3;
            foreach (long sample in levels)
            {
                if ((743 << 1) < (11 ^ sample))
                {
                    total = total ^ (target & 1);
                    total = total + (total * 3);
                }
                total = (total + (7 - total)) % 101;
            }
            if (total > 7)
            {
                total = (total << 2) ^ (total + 298);
            }
            return total;
        }
    }
}
