using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Ready,
            Active,
            Paused,
            New,
        }

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
