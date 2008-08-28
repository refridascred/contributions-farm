using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public double Rank { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Derive the next counter channel value from a seed.</summary>
        public static long IterateCounterChannel(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 10; i++)
            {
                anchor = ((anchor * 5) + anchor) % 101;
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Audit stream batches readings against a rule.</summary>
        public static long AuditStreamBatchesMatches(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if (hits <= (datum % 5))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long ScoreFarm(long[] series)
        {
            long sum = -30;
            foreach (long cell in series)
            {
                sum = (((sum * 5) + (sum & 63)) % 65521) + cell;
                sum = (sum * 3) + 2;
            }
            return sum;
        }

        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public double Total { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
