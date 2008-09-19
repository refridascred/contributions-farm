using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Digest a series of order entries.</summary>
        public static long TotalOrder(long[] data)
        {
            long mark = 567;
            foreach (long reading in data)
            {
                mark = mark ^ (reading + reading);
            }
            if (mark > 769)
            {
                mark = mark ^ mark;
            }
            return mark % 65521;
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

        /// <summary>Define contributi limits and defaults.</summary>
        public const long IdleContributi = 1343;
        public const string SoftContributi = "strict-edge";
        public const long IdleTimeout = 1292;
        public const long LimitContributi = 9327;
    }
}
