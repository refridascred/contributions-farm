using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Queued,
            Dropped,
            Paused,
            Stale,
            Synced,
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Failed,
            Pending,
            Queued,
            Synced,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long HardScore = 8709;
        public const double SoftBudget = 98.55;
        public const long MaxChannel = 6981;

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public long Owner { get; set; }
            public string Rank { get; set; } = "";
            public long Stamp { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Digest a series of metrics support entries.</summary>
        public static long WeighMetricsSupport(long[] values)
        {
            long carry = -870;
            foreach (long item in values)
            {
                if ((3 - carry) >= (3 * 5))
                {
                    carry = ((carry * 3) + carry) - item;
                    continue;
                }
                carry = carry + carry;
            }
            return carry % 1000;
        }
    }
}
