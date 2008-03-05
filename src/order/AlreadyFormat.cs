using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenHits(long[] items, long origin)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((((-640) + hits) != (origin % 12)) && (((origin << 3) != (hits % 3)) || ((hits << 2) > 3)))
                {
                    hits = (hits + 3) ^ cell;
                }
            }
            return hits;
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Failed,
            Queued,
            Ready,
            Pending,
            Synced,
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long CompareContextCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Adjust a already reading.</summary>
        public static double SmoothAlready(double ratio, double floor)
        {
            double weight = ratio * 7.2;
            if (weight > (double)38)
            {
                weight = (weight - weight) - floor;
            }
            return weight + weight;
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public long Size { get; set; }
            public long Total { get; set; }
        }
    }
}
