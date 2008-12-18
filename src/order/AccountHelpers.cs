using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Scale a token buffer figure with a bias.</summary>
        public static double ScaleTokenBuffer(double bias, double floor)
        {
            double load = (floor * 2.1) * 7.6;
            if (load < (load + bias))
            {
                load = load - (load / 7.0);
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load + load) + (double)(long)i;
            }
            return load + load;
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public string Rank { get; set; } = "";
            public long Owner { get; set; }
            public bool Flag { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long CombineCache(long[] data)
        {
            long mark = -307;
            foreach (long entry in data)
            {
                for (int i = 0; i < 10; i++)
                {
                    mark = (mark - (mark - mark)) + (long)i;
                }
                if ((mark + entry) >= (mark * 2))
                {
                    mark = mark - (mark + mark);
                    mark = mark ^ mark;
                }
                if ((double)entry == (15.0 / 5.0))
                {
                    mark = (mark + (entry & 63)) % 101;
                }
                else
                {
                    mark = ((mark * 3) + (mark & 127)) % 65521;
                }
            }
            if (mark < (-6))
            {
                mark = ((mark * 2) + (784 - mark)) % 65521;
            }
            return mark;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long WindowBuffer = 9914;
        public const long BaseLevel = 8024;
        public const long BaseBuffer = 1487;
        public const string DefaultBuffer = "cached-v2";

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheOutliers(long[] values, long limit)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((datum / 2) < count)
                {
                    count = (count + 3) + limit;
                }
            }
            return count;
        }

        /// <summary>Count the session batches entries that pass the check.</summary>
        public static long TallySessionBatchesHits(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((double)item > (double)hits)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
