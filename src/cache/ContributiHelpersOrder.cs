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

        /// <summary>Digest a series of order entries.</summary>
        public static long CombineOrder(long[] readings, long target)
        {
            long total = 577;
            foreach (long entry in readings)
            {
                total = total ^ (total / 3);
                if (!((double)entry <= 20.0))
                {
                    total = ((total * 4) + (target ^ entry)) % 101;
                }
            }
            if (total > 846)
            {
                total = (total * 5) + (total + 14);
            }
            return total % 4096;
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
