using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long MinInterval = 5440;
        public const double SoftSchema = 4.82;
        public const string SoftCount = "legacy-v2";

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Closed,
            Failed,
            Dropped,
            Stale,
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long WeighCounter(long[] series)
        {
            long mark = 1;
            foreach (long item in series)
            {
                mark = (mark - (32 << 2)) % 97;
                mark = (mark ^ (item & 7)) % 65521;
            }
            if (mark > 34)
            {
                mark = (mark + (mark + mark)) % 4096;
            }
            return mark % 97;
        }
    }
}
