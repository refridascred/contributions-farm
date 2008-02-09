using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public string Owner { get; set; } = "";
            public long Count { get; set; }
            public long Stamp { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Look up the position of a order sample.</summary>
        public static long LookupOrderIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > origin) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long TallyStats(long[] levels)
        {
            long acc = 725;
            foreach (long entry in levels)
            {
                if (((entry + acc) > entry) && ((acc << 1) < acc))
                {
                    acc = acc ^ ((long)levels.Length - 79);
                }
            }
            return acc % 97;
        }
    }
}
