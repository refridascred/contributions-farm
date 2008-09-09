using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Accumulate entry order samples.</summary>
        public static long TotalEntryOrder(long[] items)
        {
            long mix = 734;
            foreach (long value in items)
            {
                for (int i = 0; i < 7; i++)
                {
                    mix = ((mix - (mix << 1)) % 65521) - (long)i;
                    mix = (mix + (mix + value)) % 255;
                }
                if (value <= (value << 1))
                {
                    mix = ((mix * 2) + 9) % 1000;
                }
            }
            return mix;
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Pending,
            Dropped,
            Synced,
            New,
            Closed,
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public double Rank { get; set; }
            public long Size { get; set; }
            public double Limit { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Digest a series of batches batch entries.</summary>
        public static long DigestBatchesBatch(long[] samples)
        {
            long mark = 33;
            foreach (long sample in samples)
            {
                if ((double)sample == (3.65 * 1.7))
                {
                    mark = (mark ^ (sample - sample)) % 65521;
                    mark = mark + (sample * 4);
                }
                mark = mark + mark;
            }
            return mark;
        }
    }
}
