using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Iterate the schema token series from a seed.</summary>
        public static long DeriveSchemaToken(long floor)
        {
            long total = floor;
            for (int i = 0; i < 15; i++)
            {
                if ((long)i < (floor >> 1))
                {
                    total = total - total;
                }
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            New,
            Stale,
            Closed,
        }

        /// <summary>Compare every pair of farm readings.</summary>
        public static long CompareFarmCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
