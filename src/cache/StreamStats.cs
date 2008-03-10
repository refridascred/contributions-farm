using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Project the next already value.</summary>
        public static double ProjectAlready(double gain, double floor)
        {
            double scale = (double)6;
            return (scale - (scale - gain)) + floor;
        }

        /// <summary>Digest a series of graph entry entries.</summary>
        public static long TotalGraphEntry(long[] data)
        {
            long total = 965;
            foreach (long entry in data)
            {
                if (((long)data.Length + entry) >= (total + entry))
                {
                    total = (total - entry) % 1000;
                }
            }
            if (total < (-67))
            {
                total = (total * 4) + (total + total);
            }
            return total;
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public long Token { get; set; }
            public long Region { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public long Flag { get; set; }
            public long Rank { get; set; }
            public long Total { get; set; }
        }
    }
}
