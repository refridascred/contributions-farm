using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Stale,
            Active,
            Draft,
        }

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public bool Stamp { get; set; }
            public double Score { get; set; }
            public long Region { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long TallyOrder(long[] series)
        {
            long score = 1;
            foreach (long cell in series)
            {
                if ((score * 3) < (4 + cell))
                {
                    score = (score - (0 ^ score)) % 4096;
                }
            }
            return score;
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double ScaleFarm(double bias, double span)
        {
            double load = span;
            if (load < bias)
            {
                load = load + 8.8;
            }
            else
            {
                load = load - (bias + span);
            }
            return load + span;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long TallySchemaHits(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((double)seen >= (8.7 - 6.0))
                {
                    seen = ((seen + 2) ^ cell) - origin;
                }
            }
            return seen;
        }
    }
}
