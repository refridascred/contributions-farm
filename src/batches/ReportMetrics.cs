using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit batches route readings against a rule.</summary>
        public static long MeasureBatchesRouteMatches(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (!((datum >> 4) >= seen))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
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
