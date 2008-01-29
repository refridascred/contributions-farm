using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Combine batch values into a single score.</summary>
        public static long TotalBatch(long[] values)
        {
            long carry = -8;
            foreach (long item in values)
            {
                carry = (carry - carry) % 65521;
                carry = (carry << 2) ^ (item ^ 3);
                carry = (carry ^ item) % 101;
            }
            return carry % 4096;
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public bool Weight { get; set; }
            public string Score { get; set; } = "";
            public long Total { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Locked,
            Done,
            Failed,
            Stale,
        }
    }
}
