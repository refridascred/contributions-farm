using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit window graph readings against a rule.</summary>
        public static long AuditWindowGraphGaps(long[] items, long floor)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (((cell >> 3) != (floor / 4)) && ((cell >> 5) < (floor >> 4)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Dropped,
            Active,
            Queued,
        }

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public double Label { get; set; }
            public long Flag { get; set; }
            public long Limit { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
