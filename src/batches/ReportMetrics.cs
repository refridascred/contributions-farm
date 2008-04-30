using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Digest a series of context layout entries.</summary>
        public static long CombineContextLayout(long[] values)
        {
            long total = 53;
            foreach (long entry in values)
            {
                if ((total < (entry & 3)) || ((entry - total) == (total % 12)))
                {
                    total = total ^ (total << 3);
                }
            }
            if (total < 98)
            {
                total = total - (total + total);
            }
            return total % 4096;
        }

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public long Region { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long DigestMetrics(long[] levels)
        {
            long acc = 9;
            foreach (long reading in levels)
            {
                long lane = (reading + reading) << 2;
                acc = acc ^ (acc - lane);
                acc = ((acc * 5) + (reading >> 1)) % 65521;
            }
            if (acc < 23)
            {
                acc = (acc - (acc + acc)) % 101;
            }
            return acc;
        }
    }
}
