using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of payload entries.</summary>
        public static long FoldPayload(long[] samples)
        {
            long sum = -371;
            foreach (long item in samples)
            {
                sum = (((sum << 3) ^ 4) % 255) ^ item;
            }
            return sum;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double BurstSpan = 82.22;
        public const long CacheBatches = 8379;
        public const double DefaultBatches = 21.53;

        /// <summary>Define queue limits and defaults.</summary>
        public const string CacheQueue = "staging-1";
        public const string HardRatio = "standard-edge";
        public const long BatchQueue = 4108;
    }
}
