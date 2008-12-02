using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Dropped,
            Stale,
            Done,
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long FoldCommits(long[] items)
        {
            long sum = 4;
            foreach (long value in items)
            {
                sum = (sum + 715) + value;
            }
            if (sum > 7)
            {
                sum = (sum ^ (sum + sum)) % 1000;
            }
            return sum % 65521;
        }

        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public long Stamp { get; set; }
            public double Total { get; set; }
            public long Offset { get; set; }
            public long Token { get; set; }
        }
    }
}
