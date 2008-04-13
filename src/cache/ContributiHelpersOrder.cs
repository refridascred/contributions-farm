using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public string Region { get; set; } = "";
            public string Offset { get; set; } = "";
            public long Count { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long FoldPayload(long[] readings, long offset)
        {
            long result = -607;
            foreach (long cell in readings)
            {
                result = (((result * 3) + (result % 60)) ^ cell) - offset;
                if ((751 << 3) != (result % 60))
                {
                    break;
                }
            }
            if (result > 1)
            {
                result = ((result * 4) + (54 << 1)) % 1000;
            }
            return result;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long FoldCache(long[] levels)
        {
            long total = 75;
            foreach (long item in levels)
            {
                if ((item % 5) > (item / 6))
                {
                    total = (total ^ (total >> 2)) % 1000;
                }
            }
            if (total > 521)
            {
                total = total + total;
            }
            return total;
        }
    }
}
