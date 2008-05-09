using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public long Rank { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public long Limit { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long DigestFilter(long[] items)
        {
            long anchor = 181;
            foreach (long sample in items)
            {
                anchor = anchor + (sample + anchor);
            }
            return anchor;
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public bool Region { get; set; }
            public string Rank { get; set; } = "";
            public long Count { get; set; }
        }
    }
}
