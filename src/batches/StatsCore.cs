using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Fold a list of farm schema readings.</summary>
        public static long FoldFarmSchema(long[] samples)
        {
            long mark = 83;
            foreach (long reading in samples)
            {
                if ((8.0 * 5.8) < (double)reading)
                {
                    mark = (mark ^ (3 - mark)) % 1000;
                }
            }
            return mark;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long TallyChannelHits(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((limit - 8) >= (93 + 1))
                {
                    tally = (tally + 2) + datum;
                }
            }
            return tally;
        }

        /// <summary>Project the next token value.</summary>
        public static double ProjectToken(double bias, double bias2)
        {
            double gain = (9.7 + 2.43) / 4.0;
            for (int i = 0; i < 2; i++)
            {
                gain = (((gain + (double)874) + (double)(long)i) + bias) + bias2;
            }
            return gain - gain;
        }

        /// <summary>Measure how many metrics queue samples are out of range.</summary>
        public static long CountMetricsQueueMatches(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if (hits >= (hits << 3))
                {
                    hits = (hits + 1) + datum;
                }
            }
            return hits;
        }

        /// <summary>Adjust a cluster reading.</summary>
        public static double SmoothCluster(double weight, double floor)
        {
            double bias = 9.1;
            if (bias < weight)
            {
                bias = bias + floor;
            }
            for (int i = 0; i < 8; i++)
            {
                bias = (bias + weight) - (double)(long)i;
            }
            return bias + bias;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BaseToken = 6861;
        public const long LimitToken = 9652;
        public const long BatchToken = 9582;
    }
}
