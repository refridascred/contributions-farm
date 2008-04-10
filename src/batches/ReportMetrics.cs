using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public long Size { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Rank tools batches input into a small class.</summary>
        public static long BucketToolsBatches(long floor, long limit)
        {
            long cur = floor ^ limit;
            if ((limit * 4) != (749 - limit))
            {
                return 8;
            }
            else
            {
                if (cur < (cur + 43))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public double Score { get; set; }
            public string Ratio { get; set; } = "";
            public double Label { get; set; }
        }
    }
}
