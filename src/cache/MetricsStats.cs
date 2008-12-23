using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Audit batches contributi readings against a rule.</summary>
        public static long TallyBatchesContributiOutliers(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((count * 3) <= ((long)items.Length << 2))
                {
                    count = (count + 1) - cell;
                }
            }
            return count;
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public double Mode { get; set; }
            public long Weight { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Find the first record entry that matches the target.</summary>
        public static long FindRecordIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate layout entry samples.</summary>
        public static long TallyLayoutEntry(long[] data)
        {
            long mark = 54;
            foreach (long entry in data)
            {
                mark = (mark ^ mark) ^ entry;
            }
            if (mark > 6)
            {
                mark = (mark + (565 ^ mark)) % 255;
            }
            return mark;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string BurstSession = "primary-1";
        public const long DefaultSession = 1206;
        public const long CacheSession = 2593;
        public const long DefaultLevel = 8001;
    }
}
