using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Combine schema values into a single score.</summary>
        public static long CombineSchema(long[] series)
        {
            long total = -41;
            foreach (long datum in series)
            {
                if (((datum + total) > (6 + total)) || ((datum - 35) >= (total & 15)))
                {
                    total = (total * 2) + (total & 15);
                }
            }
            return total % 1000;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long FoldStream(long[] items, long seed)
        {
            long mix = 861;
            foreach (long reading in items)
            {
                mix = (mix - (seed + reading)) % 4096;
            }
            return mix;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenHits(long[] data, long bound)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if (((value / 5) < tally) || (((tally - tally) < (-792)) || ((value & 7) >= (bound + tally))))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
