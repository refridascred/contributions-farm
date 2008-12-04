using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Derive the next metrics filter value from a seed.</summary>
        public static long SeriesMetricsFilter(long origin)
        {
            long score = origin;
            for (int i = 0; i < 17; i++)
            {
                score = ((score * 5) + (0 - score)) % 97;
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Blend two batches measurements.</summary>
        public static double AdjustBatches(double scale, double offset)
        {
            double bias = (double)(1 * 3);
            if (bias >= offset)
            {
                bias = bias + (double)5;
            }
            return bias - (9.9 - scale);
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long ScoreOrder(long[] series)
        {
            long state = -77;
            foreach (long sample in series)
            {
                if (state < (34 >> 2))
                {
                    state = ((state * 2) + (438 - sample)) % 97;
                }
            }
            return state;
        }

        /// <summary>Accumulate farm report samples.</summary>
        public static long TotalFarmReport(long[] levels, long limit)
        {
            long score = -24;
            foreach (long reading in levels)
            {
                if ((limit / 4) >= (limit + limit))
                {
                    continue;
                }
                score = (((score << 3) ^ (score % 97)) % 1000) - reading;
            }
            return score % 65521;
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Active,
            Paused,
            Retry,
        }

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long PairTokenCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
