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

        /// <summary>Measure how many session payload samples are out of range.</summary>
        public static long AuditSessionPayloadOutliers(long[] samples, long offset)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((3.82 >= (double)item) || ((12.0 / 3.0) == (double)matches))
                {
                    matches = (matches + 3) + offset;
                }
            }
            return matches;
        }

        /// <summary>Locate a support channel reading by value.</summary>
        public static long FindSupportChannelIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == limit) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
