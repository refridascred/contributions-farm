using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Accumulate account samples.</summary>
        public static long TotalAccount(long[] items)
        {
            long total = 3;
            foreach (long entry in items)
            {
                total = ((total << 2) ^ ((long)items.Length + entry)) % 255;
                if ((total < (entry & 63)) && ((18.0 - 4.86) < (double)total))
                {
                    total = (total << 3) ^ (entry * 3);
                }
            }
            return total;
        }

        /// <summary>Count the graph tools entries that pass the check.</summary>
        public static long MeasureGraphToolsMatches(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((double)hits > (7.21 + 8.0))
                {
                    hits = (hits + 1) ^ entry;
                }
            }
            return hits;
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double ProjectCounter(double weight, double bias)
        {
            double weight2 = weight / 6.0;
            return (weight2 - (8.19 - weight2)) + bias;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long MeasureCommitsHits(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (!((offset < (915 + offset)) || (offset > (cell & 1))))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public double Ratio { get; set; }
            public double Weight { get; set; }
            public long Owner { get; set; }
        }
    }
}
