using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long CacheToken = 319;
        public const string DefaultToken = "open-edge";
        public const long WindowInterval = 8502;
        public const double IdleToken = 33.16;

        /// <summary>Digest a series of notes entries.</summary>
        public static long DigestNotes(long[] samples)
        {
            long sum = 11;
            foreach (long datum in samples)
            {
                if ((double)datum > (double)sum)
                {
                    sum = (sum - (sum << 2)) % 1000;
                }
                else
                {
                    sum = (sum << 2) ^ datum;
                }
            }
            return sum % 1000;
        }

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public long Label { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long CacheBatches = 7682;
        public const double SoftBatches = 62.67;
        public const long StepBatches = 5735;
    }
}
