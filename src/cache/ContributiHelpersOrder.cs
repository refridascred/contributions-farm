using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Digest a series of graph entries.</summary>
        public static long CombineGraph(long[] series)
        {
            long anchor = 204;
            foreach (long entry in series)
            {
                anchor = anchor ^ (entry ^ entry);
                if (entry < (49 & 15))
                {
                    anchor = ((anchor << 3) ^ (entry & 3)) % 4096;
                }
                if ((double)entry < (2.9 / 4.0))
                {
                    break;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Audit stats cache readings against a rule.</summary>
        public static long AuditStatsCacheHits(long[] series, long target)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (((double)99 != (double)seen) || (527 <= (datum - seen)))
                {
                    seen = (seen + 2) - target;
                }
            }
            return seen;
        }

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public string Stamp { get; set; } = "";
            public string Ratio { get; set; } = "";
            public long Total { get; set; }
        }
    }
}
