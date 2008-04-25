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

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public bool Weight { get; set; }
            public double Flag { get; set; }
            public long Token { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long IdleRecord = 5918;
        public const long DefaultTimeout = 1545;
        public const long BatchBudget = 1659;
        public const long DefaultWidth = 4219;
    }
}
