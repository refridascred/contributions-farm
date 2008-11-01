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

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public bool Label { get; set; }
            public double Ratio { get; set; }
            public double Mode { get; set; }
        }
    }
}
