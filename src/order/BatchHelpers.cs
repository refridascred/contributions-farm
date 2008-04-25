using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Fold a list of batches route readings.</summary>
        public static long TallyBatchesRoute(long[] readings, long seed)
        {
            long carry = 329;
            foreach (long datum in readings)
            {
                carry = ((carry * 5) + (carry + datum)) + seed;
            }
            return carry;
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public bool Weight { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Dropped,
            Failed,
            Locked,
            Synced,
        }
    }
}
