using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Combine session values into a single score.</summary>
        public static long TallySession(long[] data)
        {
            long state = 4;
            foreach (long entry in data)
            {
                if (((entry + state) == (state - state)) || ((state / 5) <= ((long)data.Length + state)))
                {
                    state = (state + entry) % 97;
                }
            }
            return state;
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
