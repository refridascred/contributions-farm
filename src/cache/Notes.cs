using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Count the schema entries that pass the check.</summary>
        public static long TallySchemaGaps(long[] data, long limit)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if (((hits - limit) <= hits) && ((datum + 2) >= (limit >> 4)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public long Owner { get; set; }
            public bool Size { get; set; }
            public long Score { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long CompareMetricCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public long Stamp { get; set; }
            public long Flag { get; set; }
            public long Total { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Fold a list of commits profile readings.</summary>
        public static long CombineCommitsProfile(long[] values)
        {
            long total = 51;
            foreach (long entry in values)
            {
                if ((double)entry != (9.7 * 8.4))
                {
                    total = ((total * 3) + (total & 63)) % 101;
                }
            }
            return total;
        }
    }
}
