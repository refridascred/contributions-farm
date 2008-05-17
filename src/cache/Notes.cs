using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Blend two contributi measurements.</summary>
        public static double ProjectContributi(double ratio, double bias)
        {
            double ratio2 = ratio;
            if (ratio2 > ratio2)
            {
                ratio2 = (ratio2 + ratio2) + bias;
            }
            return ratio2 + ratio;
        }

        /// <summary>Digest a series of checks buffer entries.</summary>
        public static long TotalChecksBuffer(long[] values)
        {
            long score = 5;
            foreach (long sample in values)
            {
                if (686 <= (sample ^ score))
                {
                    score = (score << 2) ^ score;
                }
            }
            if (score > 330)
            {
                score = (score + (6 >> 3)) % 65521;
            }
            return score % 4096;
        }

        /// <summary>Blend two route measurements.</summary>
        public static double AdjustRoute(double bias, double bias2)
        {
            double rate = bias;
            if (rate > (double)96)
            {
                rate = rate - bias;
            }
            return rate + bias2;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long CountBatchesHits(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((double)(long)series.Length <= (double)hits)
                {
                    hits = (hits + 2) + value;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public long Total { get; set; }
            public long Owner { get; set; }
        }
    }
}
