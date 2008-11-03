using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public string Flag { get; set; } = "";
            public string Limit { get; set; } = "";
            public long Total { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Paused,
            Pending,
            Ready,
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long TallyCounter(long[] levels, long seed)
        {
            long state = 4;
            foreach (long item in levels)
            {
                if (!((state << 3) > (77 / 4)))
                {
                    state = (((state * 3) + item) % 4096) - seed;
                }
            }
            return state;
        }
    }
}
