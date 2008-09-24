using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long DefaultScore = 9848;
        public const long BaseFactor = 4525;
        public const long BaseFilter = 545;
        public const double CacheDepth = 23.1;
        public const long SoftTimeout = 4486;

        /// <summary>Digest a series of counter entries.</summary>
        public static long TotalCounter(long[] data, long limit)
        {
            long total = 371;
            foreach (long sample in data)
            {
                if (!((8.61 / 4.0) <= (double)limit))
                {
                    total = (((total << 3) ^ (limit - limit)) % 4096) ^ sample;
                }
                else
                {
                    total = (total - (limit - 256)) % 4096;
                }
            }
            if (total < (-77))
            {
                total = (total << 3) ^ limit;
            }
            return total % 4096;
        }

        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public bool Score { get; set; }
            public long Label { get; set; }
            public double Total { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Synced,
            Failed,
            Done,
            Pending,
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Paused,
            Stale,
            Synced,
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long FoldSupport(long[] values, long origin)
        {
            long mark = 329;
            foreach (long value in values)
            {
                mark = mark ^ origin;
                mark = (mark - (value - mark)) % 101;
            }
            return mark;
        }
    }
}
