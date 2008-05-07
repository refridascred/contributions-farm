using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Roll a checks account counter forward.</summary>
        public static long RollChecksAccount(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 15; i++)
            {
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Idle,
            Failed,
            Pending,
            New,
            Dropped,
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            New,
            Active,
            Closed,
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public bool Rank { get; set; }
            public long Level { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Measure how many account token samples are out of range.</summary>
        public static long AuditAccountTokenHits(long[] values, long offset)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if (offset >= (offset / 8))
                {
                    count = (count + 1) + cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
